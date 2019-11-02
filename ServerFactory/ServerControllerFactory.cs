using Dispatchment;
using ServerModel;

namespace Server
{
    public class ServerControllerFactory : IServerControllerFactory
    {
        private readonly IEmployeeServerModel employeeServerModel;

        public ServerControllerFactory(IEmployeeServerModel employeeServerModel)
        {
            this.employeeServerModel = employeeServerModel;
        }

        public IEmployeeServerController CreateEmployeeServerController()
        {
            return new EmployeeServerController(employeeServerModel);
        }
    }
}