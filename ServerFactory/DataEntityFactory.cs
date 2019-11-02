using ServerDispatchment;
using SharedAbstractModel;
using SharedModel;

namespace ServerFactory
{
    public class DataEntityFactory : IDataEntityFactory
    {
        public IDataEntity CreateEmployee(string data)
        {
            return new Employee(data);
        }
    }
}