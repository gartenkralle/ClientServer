using DataTypes;

namespace TcpIp_Extended
{
    public class NetworkController
    {
        private readonly INetworkClient networkClient;

        public NetworkController(INetworkClient networkClient)
        {
            this.networkClient = networkClient;
        }

        public bool IsExisting(Employee employee)
        {
            return networkClient.IsExisting(employee);
        }
    }
}
