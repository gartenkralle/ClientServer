using Dispatchment;

namespace Server
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