using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using SilkroadSecurity;

namespace MOSROManager
{
    public class SRProxy
    {
        public static event Action OnProxyClientlessStart;
        public static event Action<Packet> OnProxyServerPacketReceive;
        public static event Action<Packet> OnProxyClientPacketSent;
        public static event Action OnProxyDisconnect;
        public static ModuleType moduleType;

        public enum ModuleType
        {
            GatewayServer,
            AgentServer
        }

        class Context
        {
            public Socket Socket { get; set; }
            public Security Security { get; set; }
            public TransferBuffer Buffer { get; set; }
            public Security RelaySecurity { get; set; }

            public Context()
            {
                Socket = null;
                Security = new Security();
                RelaySecurity = null;
                Buffer = new TransferBuffer(8192);
            }
        }

        public static void StartProxy(string remote_ip, ushort remote_port, string local_ip, ushort local_port, ModuleType module) //Pushedx proxy.
        {
            moduleType = module;

            Context local_context = new Context();
            local_context.Security.GenerateSecurity(true, true, true);

            Context remote_context = new Context();

            Common.SRClient.LocalSecurity = local_context.Security;
            Common.SRClient.RemoteSecurity = remote_context.Security;

            remote_context.RelaySecurity = local_context.Security;
            local_context.RelaySecurity = remote_context.Security;

            List<Context> contexts = new List<Context>();
            contexts.Add(local_context);
            contexts.Add(remote_context);

            using (Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                server.Bind(new IPEndPoint(IPAddress.Parse(local_ip), local_port));
                server.Listen(1);

                local_context.Socket = server.Accept();
            }

            using (local_context.Socket)
            {
                using (remote_context.Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    remote_context.Socket.Connect(remote_ip, remote_port);
                    while (true)
                    {
                        #region TransferIncoming
                        foreach (Context context in contexts) // Network input event processing
                        {
                            try
                            {
                                if (context.Socket.Poll(0, SelectMode.SelectRead))
                                {
                                    int count = context.Socket.Receive(context.Buffer.Buffer);
                                    if (count == 0)
                                    {
                                        Console.WriteLine("Null recevied, disconnected");
                                        OnProxyDisconnect?.Invoke();
                                        throw new Exception("The remote connection has been lost.");
                                    }
                                    context.Security.Recv(context.Buffer.Buffer, 0, count);
                                }
                            }
                            catch (Exception ex)
                            {
                                if (moduleType == ModuleType.GatewayServer)
                                {
                                    Common.SRClient.CloseGatewayConnection();
                                    Common.SRClient.StartGatewayProxy();
                                }
                                //else if(moduleType == ModuleType.AgentServer)
                                //{
                                //    Common.SRClient.CloseAgentConnection();
                                //    Common.SRClient.StartAgentProxy(remote_ip, remote_port);
                                //}
                                Console.WriteLine("Disconnected: " + ex.Message);
                                return;
                            }
                        }

                        foreach (Context context in contexts) // Logic event processing
                        {
                            List<Packet> packets = context.Security.TransferIncoming();
                            if (packets != null)
                            {
                                foreach (Packet packet in packets)
                                {
                                    OnProxyServerPacketReceive?.Invoke(new Packet(packet));

                                    if (packet.Opcode == 0x5000 || packet.Opcode == 0x9000) // ignore always
                                    {
                                    }
                                    else if (packet.Opcode == 0x2001)
                                    {
                                        if (context == remote_context) // ignore local to proxy only
                                        {
                                            context.RelaySecurity.Send(packet); // proxy to remote is handled by API
                                        }
                                    }
                                    else if (packet.Opcode == 0xA102)
                                    {
                                        byte result = packet.ReadByte();
                                        if (result == 1)
                                        {
                                            uint SessionID = packet.ReadUInt();
                                            string ip = packet.ReadAscii();
                                            ushort port = packet.ReadUShort();

                                            Common.SRClient.StartAgentProxy(ip, ushort.Parse((port).ToString()));

                                            Thread.Sleep(50);

                                            //Fake response to redirect the client.
                                            Packet new_packet = new Packet(0xA102, true);
                                            new_packet.WriteByte(result);
                                            new_packet.WriteUInt(SessionID);
                                            new_packet.WriteAscii(local_ip);
                                            new_packet.WriteUShort(local_port);

                                            context.RelaySecurity.Send(new_packet);
                                        }
                                        else
                                        {
                                            context.RelaySecurity.Send(packet);
                                        }
                                    }
                                    else
                                    {
                                        context.RelaySecurity.Send(packet);
                                    }
                                }
                            }
                        }
                        #endregion
                        #region TransferOutgoing
                        foreach (Context context in contexts) // Network output event processing
                        {
                            if (context.Socket.Poll(0, SelectMode.SelectWrite))
                            {
                                List<KeyValuePair<TransferBuffer, Packet>> buffers = context.Security.TransferOutgoing();
                                if (buffers != null)
                                {
                                    foreach (KeyValuePair<TransferBuffer, Packet> kvp in buffers)
                                    {
                                        TransferBuffer buffer = kvp.Key;
                                        OnProxyClientPacketSent?.Invoke(kvp.Value);

                                        Packet packet = kvp.Value;
                                        byte[] packet_bytes = packet.GetBytes();
                                        //Console.WriteLine("[{7}] [{0}][{1:X4}][{2} bytes]{3}{4}{6}{5}{6}", context == local_context ? "S->C" : "C->S", packet.Opcode, packet_bytes.Length, packet.Encrypted ? "[Encrypted]" : "", packet.Massive ? "[Massive]" : "", Utility.HexDump(packet_bytes), Environment.NewLine, moduleType);
                                        Common.Dashboard.PacketSniffer.AddPacket(packet, moduleType.ToString(), context == local_context ? "Server" : "Client");

                                        while (true)
                                        {
                                            int count = context.Socket.Send(buffer.Buffer, buffer.Offset, buffer.Size, SocketFlags.None);
                                            buffer.Offset += count;
                                            if (buffer.Offset == buffer.Size)
                                                break;
                                            Thread.Sleep(1);
                                        }
                                    }
                                }
                            }
                        }
                        #endregion
                        Thread.Sleep(1);
                    }
                }
            }
        }

    }
}