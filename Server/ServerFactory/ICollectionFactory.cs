using Server.Controller;

namespace Server.Factory
{
    public interface ICollectionFactory
    {
        IEmployeeCollection CreateEmployeeCollection();
    }
}