using Server.Model;

namespace Server.Factory
{
    public class CollectionFactory : ICollectionFactory
    {
        public EmployeeCollection CreateEmployeeCollection()
        {
            return new EmployeeCollection();
        }
    }
}