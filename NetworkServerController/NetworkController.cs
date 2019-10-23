using System;
using TcpIp_Extended;

namespace NetworkServerController
{
    public class NetworkController
    {
        private readonly INetworkServer networkClient;

        public NetworkController(INetworkServer networkClient)
        {
            this.networkClient = networkClient;
        }
    }
}
