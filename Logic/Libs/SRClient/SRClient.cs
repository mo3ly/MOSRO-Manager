using SilkroadSecurity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MOSROManager
{
    class SRClient
    {
        /*
         * TODO:
         * read the port dynamically
         * read ip from media and find ip from dns if needed
         * find avaliable port
         */

        public Security RemoteSecurity;
        public Security LocalSecurity;
        public Thread gatewayThread;
        public Thread agentThread;

        private string SRClientPath;
        private string remote_host;
        private ushort remote_port;
        private string local_host;
        private ushort local_port;
        private byte local;

        public SRClient(string clientPath, string localIP, string remoteIP, ushort remotePort)
        {
            SRClientPath = clientPath;
            remote_host = GetClientIP(remoteIP);//GetClientIP("strasbourg2.maxiguard.org");// ; Dns.GetHostAddresses("51.178.190.144")[0].ToString();//"192.168.1.67"; // Dns.GetHostAddresses("strasbourg2.maxiguard.org")[0].ToString();
            remote_port = remotePort;//7001; //15779;
            local = 22;
            local_host = localIP;
            local_port = GetUnusedPort(2000);
            Console.WriteLine("[local_port]" + local_port);
        }

        public void StartClient()
        {
            try
            {
                // proxy
                StartGatewayProxy();

                // loader
                ClientLoader();
            }
            catch { }
        }

        public void ClientLoader()
        {
            Loader loader = new Loader();
            loader.StartClient(SRClientPath, local_port, local);
        }

        public void StartGatewayProxy()
        {
            try
            {
                gatewayThread = new Thread(() => SRProxy.StartProxy(remote_host, remote_port, local_host, local_port, SRProxy.ModuleType.GatewayServer));
                gatewayThread.Start();
            }
            catch
            {
                Common.Dashboard.writeLog("Error while establishing the Gateway thread for the proxy connection.", 0);
            }
        }

        public void StartAgentProxy(string AgentIP, ushort AgentPort)
        {
            try
            {
                agentThread = new Thread(() => SRProxy.StartProxy(AgentIP, AgentPort, local_host, local_port, SRProxy.ModuleType.AgentServer));
                agentThread.Start();
            }
            catch
            {
                Common.Dashboard.writeLog("Error while establishing the Agent thread for the proxy connection.", 0);
            }
        }

        public void CloseGatewayConnection()
        {
            try
            {
                if (gatewayThread.IsAlive)
                    gatewayThread.Abort();
            }
            catch
            {
                Common.Dashboard.writeLog("Error while closing the gateway proxy connection.", 0);
            }
        }

        public void CloseAgentConnection()
        {
            try
            {
                if (agentThread.IsAlive)
                    agentThread.Abort();

            }
            catch
            {
                Common.Dashboard.writeLog("Error while closing the agent proxy connection.", 0);
            }
        }

        public string GetClientIP(string Domain)
        {
            try
            {
                return Dns.GetHostAddresses(Domain)[0].ToString();
            }
            catch
            {
                Common.Dashboard.writeLog("Error while retrieving the client IP, couldn't establish the connection.", 0);
                return null;
            }
        }

        public static ushort GetUnusedPort(int startingPort) //https://gist.github.com/jrusbatch/4211535
        {
            try
            {

                var properties = IPGlobalProperties.GetIPGlobalProperties();

                //getting active connections
                var tcpConnectionPorts = properties.GetActiveTcpConnections()
                                    .Where(n => n.LocalEndPoint.Port >= startingPort)
                                    .Select(n => n.LocalEndPoint.Port);

                //getting active tcp listners - WCF service listening in tcp
                var tcpListenerPorts = properties.GetActiveTcpListeners()
                                    .Where(n => n.Port >= startingPort)
                                    .Select(n => n.Port);

                //getting active udp listeners
                var udpListenerPorts = properties.GetActiveUdpListeners()
                                    .Where(n => n.Port >= startingPort)
                                    .Select(n => n.Port);

                var port = Enumerable.Range(startingPort, ushort.MaxValue)
                    .Where(i => !tcpConnectionPorts.Contains(i))
                    .Where(i => !tcpListenerPorts.Contains(i))
                    .Where(i => !udpListenerPorts.Contains(i))
                    .FirstOrDefault();

                return (ushort)port;
            }
            catch
            {
                Common.Dashboard.writeLog("Error while finding unused local port, couldn't establish the connection.", 0);
                return 0;
            }
        }

        public void SendToServer(Packet packet)
        {
            RemoteSecurity?.Send(packet);
        }

        public void SendToClient(Packet packet)
        {
            LocalSecurity?.Send(packet);
        }

        public void SendNotice(string message)
        {
            Packet packet = new Packet(0x3026);
            packet.WriteByte(7);
            packet.WriteAscii(message);
            SendToClient(packet);
        }
    }
}
