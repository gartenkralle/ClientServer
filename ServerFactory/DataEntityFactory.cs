using DataTypes;
using Dispatchment;

namespace Server
{
    public class DataEntityFactory : IDataEntityFactory
    {
        public IDataEntity CreateEmployee(string data)
        {
            return new Employee(data);
        }
    }
}