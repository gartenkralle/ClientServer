using Server.Controller;
using Server.Model;

namespace Server.Factory
{
    public class CollectionFactory : ICollectionFactory
    {
        public IEmployeeCollection CreateEmployeeCollection()
        {
            return new EmployeeCollection();
        }
    }
}