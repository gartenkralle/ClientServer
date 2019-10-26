using DataTypes;

namespace TcpIp_Extended
{
    public class NetworkClientController
    {
        private readonly INetworkClient networkClient;

        public NetworkClientController(INetworkClient networkClient)
        {
            this.networkClient = networkClient;
        }

        public bool IsExisting(Employee employee)
        {
            return networkClient.IsExisting(employee);
        }
    }
}
