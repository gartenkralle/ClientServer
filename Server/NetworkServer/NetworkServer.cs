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

        public string Receive()
        {
            return concreteNetworkServer.Receive();
        }

        public void Send(string data)
        {
            concreteNetworkServer.Send(data);
        }
    }
}
