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

        public bool IsExisting(Employee employee)
        {
            concreteNetworkClient.Send(nameof(Employee), employee.ToString());

            string response = concreteNetworkClient.Receive();

            return bool.Parse(response);
        }
    }
}
