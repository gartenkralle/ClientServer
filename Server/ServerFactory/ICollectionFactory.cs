using Server.Model;

namespace Server.Factory
{
    public interface ICollectionFactory
    {
        EmployeeCollection CreateEmployeeCollection();
    }
}