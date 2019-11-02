using ServerController;
using ServerModel;

namespace ServerFactory
{
    public class DataEntityModelFactory : IDataEntityModelFactory
    {
        public IEmployeeServerModel CreateEmployeeServerModel()
        {
            return new EmployeeServerModel();
        }
    }
}