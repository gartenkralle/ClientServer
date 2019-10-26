using DataTypes;
using TcpIp_Extended;
using TcpIp_Server;
using TcpServer;

namespace Server
{
    class ServerProgram
    {
        static void Main()
        {
            NetworkServerController networkServerController = new NetworkServerController(new NetworkServer(new ConcreteNetworkServer()));

            while (true)
            {
                string request = networkServerController.Receive();

                string response = Dispatch(request);

                networkServerController.Send(response);
            }
        }

        static string Dispatch(string request)
        {
            string response = null;

            Request requestEntity = new Request(request);

            if (requestEntity.Type == "Employee")
            {
                EmployeeController employeeController = new EmployeeController();

                if (requestEntity.Function == "IsExisting")
                {
                    response = employeeController.IsExisting(new Employee(requestEntity.Data)).ToString();
                }
            }

            return response;
        }
    }
}