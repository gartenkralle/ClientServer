using System;
using TcpIp_Extended;

namespace TcpIp_Server
{
    public class NetworkServer : INetworkServer
    {
        private readonly IConcreteNetworkServer concreteNetworkServer;

        public NetworkServer(IConcreteNetworkServer concreteNetworkServer)
        {
            this.concreteNetworkServer = concreteNetworkServer;
        }

        public void Send(string data)
        {
            concreteNetworkServer.Send(data);
        }

        public string Receive()
        {
            return concreteNetworkServer.Receive();
        }
    }
}
