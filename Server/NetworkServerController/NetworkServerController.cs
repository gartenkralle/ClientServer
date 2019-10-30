using DataTypes;
using TcpIp_Extended;
using TcpServer;

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

        public static string Dispatch(string request)
        {
            string response = null;

            Request requestEntity = new Request(request);

            if (requestEntity.Type == "Employee")
            {
                EmployeeServerController employeeController = new EmployeeServerController();

                if (requestEntity.Function == "IsExisting")
                {
                    response = employeeController.IsExisting(new Employee(requestEntity.Data)).ToString();
                }
            }

            return response;
        }
    }
}
