using DataTypes;
using Server;
using ServerModel;
using TcpServer;

namespace Dispatchment
{
    public static class Dispatcher
    {
        public static string Dispatch(string request)
        {
            string response = null;

            Request requestEntity = new Request(request);

            if (requestEntity.Type == "Employee")
            {
                EmployeeServerController employeeController = new EmployeeServerController(new EmployeeServerModel());

                if (requestEntity.Function == "IsExisting")
                {
                    response = employeeController.IsExisting(new Employee(requestEntity.Data)).ToString();
                }
            }

            return response;
        }
    }
}
