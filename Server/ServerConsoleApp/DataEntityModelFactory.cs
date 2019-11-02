using ServerModel;

namespace Server
{
    internal class DataEntityModelFactory : IDataEntityModelFactory
    {
        public IEmployeeServerModel CreateEmployeeServerModel()
        {
            return new EmployeeServerModel();
        }
    }
}