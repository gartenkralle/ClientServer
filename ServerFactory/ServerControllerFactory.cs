using ServerController;
using ServerDispatchment;

namespace ServerFactory
{
    public class ServerControllerFactory : IServerControllerFactory
    {
        private readonly IDataEntityModelFactory dataEntityModelFactory;

        public ServerControllerFactory(IDataEntityModelFactory dataEntityModelFactory)
        {
            this.dataEntityModelFactory = dataEntityModelFactory;
        }

        public IEmployeeServerController CreateEmployeeServerController()
        {
            return new EmployeeServerController(dataEntityModelFactory.CreateEmployeeServerModel());
        }
    }
}