using System;
using DataTypes;
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

        public bool IsExisting(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
