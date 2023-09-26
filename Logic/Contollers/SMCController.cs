using SilkroadSecurity;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace MOSROManager
{
    class SMCController
    {
        static Security gw_security = new Security();
        static TransferBuffer gw_recv_buffer = new TransferBuffer(4096, 0, 0);
        static List<Packet> gw_packets = new List<Packet>();
        static Socket gw_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Thread loop;
        static Timer timer1;
        static Timer timer2;
        static string username;
        static string password;

        public bool Start(string IP, string Port,string User, string Pass)
        {
            try
            {
                username = User;
                password = Pass;

                if (loop != null)
                {
                    loop.Abort();
                    timer1.Dispose();
                    timer2.Dispose();
                    gw_security = new Security();
                    gw_recv_buffer = new TransferBuffer(4096, 0, 0);
                    gw_packets = new List<Packet>();
                }

                gw_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                loop = new Thread(Gateway_thread);

                try
                {
                    gw_socket.Connect(IP, int.Parse(Port));
                }
                catch
                {
                    Common.Dashboard.writeLog("An error occured while running SMC.", 0);
                    return false;
                }

                loop.Start();
                gw_socket.Blocking = false;
                gw_socket.NoDelay = true;

                return true;
            } 
            catch
            {
                return false;
            }
        }

        public void Stop()
        {
            try
            {
                loop.Abort();
                timer1.Dispose();
                timer2.Dispose();
                gw_security = new Security();
                gw_recv_buffer = new TransferBuffer(4096, 0, 0);
                gw_packets = new List<Packet>();
            } catch { }
        }

        public static void Ping_2002(object e)
        {
            Packet p = new Packet(0x2002);
            SendToServer(p);
        }

        public static void Ping_7204(object e)
        {
            Packet p = new Packet(0x7204);
            SendToServer(p);
        }

        public void Gateway_thread()
        {
            while (true)
            {
                gw_security.ChangeIdentity("ServiceManager", 0);
                SocketError err = default(SocketError);
                gw_recv_buffer.Size = gw_socket.Receive(gw_recv_buffer.Buffer, 0, gw_recv_buffer.Buffer.Length, SocketFlags.None, out err);
                if (err != SocketError.Success)
                {
                    if (err != SocketError.WouldBlock)
                    {
                        break;
                    }
                }
                else
                {
                    if (gw_recv_buffer.Size > 0)
                        gw_security.Recv(gw_recv_buffer);
                    else
                        break;
                }
                List<Packet> tmp_packets = gw_security.TransferIncoming();
                if (tmp_packets != null)
                {
                    gw_packets.AddRange(tmp_packets);
                }


                if (gw_packets.Count > 0)
                {
                    foreach (Packet packet in gw_packets)
                    {
                        byte[] packet_bytes = packet.GetBytes();
                        if (packet.Opcode == 0x5000 || packet.Opcode == 0x9000)
                            continue;

                        if (packet.Opcode == 0x6005)
                        {
                            Packet loginauth = new Packet(0x7001);
                            loginauth.WriteAscii(username);
                            loginauth.WriteAscii(ToMD5(password));
                            loginauth.WriteAscii(ToMD5(""));
                            loginauth.WriteUShort(24);
                            loginauth.WriteUShort(0);

                            gw_security.Send(loginauth);

                            Common.Dashboard.writeLog("Logged in succeffully to SMC.", 1);
                        }


                        if (packet.Opcode == 0xb001)
                        {
                            byte byte_1 = packet.ReadByte();
                            byte byte_2 = packet.ReadByte();

                            if (byte_1 == 1 && byte_2 == 1)
                            {
                                timer1 = new Timer(new TimerCallback(Ping_7204), null, 0, 1000);
                                timer2 = new Timer(new TimerCallback(Ping_2002), null, 0, 4000);
                                GatewayServiceStart();
                                GameServiceStart();
                                Common.Dashboard.writeLog("[SMC] Game servies are running successfully.", 1);
                            }
                            else
                            {
                                Common.Dashboard.writeLog("The entered credentials are not a valid SMC user, ID/PW are wrong.", 0);
                            }
                        }

                        if (packet.Opcode == 0xB201)
                        {
                            byte flag = packet.ReadByte();
                            if (flag == 0x01)
                                Console.WriteLine("Successfuly kicked player");
                            else
                            {
                                byte error_flag = packet.ReadByte();
                                if (error_flag == 0x01)
                                {
                                    Console.WriteLine("Couldn't kick player,the player is not found or not online");
                                }
                            }
                        }

                        if (packet.Opcode == 0xb005)
                        {


                        }

                    }
                    gw_packets.Clear();
                }

                List<KeyValuePair<TransferBuffer, Packet>> tmp_buffers = gw_security.TransferOutgoing();

                if (tmp_buffers != null)
                {
                    dynamic kvp = null;
                    foreach (var kvp_loopVariable in tmp_buffers)
                    {
                        kvp = kvp_loopVariable;
                        TransferBuffer buffer = kvp.Key;
                        Packet packet = kvp.Value;
                        err = SocketError.Success;

                        while (buffer.Offset != buffer.Size)
                        {
                            int sent = gw_socket.Send(buffer.Buffer, buffer.Offset, buffer.Size - buffer.Offset, SocketFlags.None, out err);
                            if (err != SocketError.Success)
                            {
                                if (err != SocketError.WouldBlock)
                                    break;
                            }


                            buffer.Offset += sent;
                            Thread.Sleep(1);
                        }

                        if (err != SocketError.Success)
                            break;
                    }

                    if (err != SocketError.Success)
                    {
                        break;
                    }
                }
                Thread.Sleep(1);
            }
        }

        public static void SendToServer(Packet packet)
        {
            gw_security.Send(packet);
        }

        public static string ToMD5(string text)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(text));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString().ToLower();
            }
        }

        public void GameServiceStart()
        {
            Packet start_shard = new Packet(0x7008);
            start_shard.WriteByte(1);
            start_shard.WriteUShort(705);

            SendToServer(start_shard);

            Packet start_agent = new Packet(0x7008);
            start_agent.WriteByte(1);
            start_agent.WriteUShort(707);

            SendToServer(start_agent);

            Packet start_gs = new Packet(0x7008);
            start_gs.WriteByte(1);
            start_gs.WriteUShort(713);

            SendToServer(start_gs);
        }

        public void GatewayServiceStart()
        {
            Packet start_global = new Packet(0x7008);
            start_global.WriteByte(1);
            start_global.WriteUShort(697);

            SendToServer(start_global);

            Packet start_download = new Packet(0x7008);
            start_download.WriteByte(1);
            start_download.WriteUShort(700);

            SendToServer(start_download);

            Packet start_gateway = new Packet(0x7008);
            start_gateway.WriteByte(1);
            start_gateway.WriteUShort(698);

            SendToServer(start_gateway);

            Packet start_farm = new Packet(0x7008);
            start_farm.WriteByte(1);
            start_farm.WriteUShort(704);

            SendToServer(start_farm);
        }
    }
}
