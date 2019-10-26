using DataTypes;

namespace TcpIp_Extended
{
    public class NetworkClient : INetworkClient
    {
        private readonly IConcreteNetworkClient concreteNetworkClient;

        public NetworkClient(IConcreteNetworkClient concreteNetworkClient)
        {
            this.concreteNetworkClient = concreteNetworkClient;
        }

        public string Receive()
        {
            return concreteNetworkClient.Receive();
        }

        public void Send(string type, string function, string data)
        {
            concreteNetworkClient.Send(type, function, data);
        }
    }
}
