using Server.Dispatchment;
using Server.Controller;

namespace Server.Factory
{
    public class ControllerFactory : IControllerFactory
    {
        private readonly ICollectionFactory collectionFactory;

        public ControllerFactory(ICollectionFactory dataEntityModelFactory)
        {
            this.collectionFactory = dataEntityModelFactory;
        }

        public IEmployeeController CreateEmployeeController()
        {
            return new EmployeeController(collectionFactory.CreateEmployeeCollection());
        }
    }
}