using Dispatchment;
using ServerModel;

namespace Server
{
    internal class ServerControllerFactory : IServerControllerFactory
    {
        public IEmployeeServerController CreateEmployeeServerController()
        {
            return new EmployeeServerController(new EmployeeServerModel());
        }
    }
}