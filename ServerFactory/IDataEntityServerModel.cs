using ServerController;

namespace ServerFactory
{
    public interface IDataEntityModelFactory
    {
        IEmployeeServerModel CreateEmployeeServerModel();
    }
}