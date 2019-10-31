using TcpIp_Extended;

namespace Server
{
    public class NetworkServerController
    {
        private readonly INetworkServer networkServer;

        public NetworkServerController(INetworkServer networkServer)
        {
            this.networkServer = networkServer;
        }

        public string Receive()
        {
            return networkServer.Receive();
        }

        public void Send(string data)
        {
            networkServer.Send(data);
        }
    }
}
