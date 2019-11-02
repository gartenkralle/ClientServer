using DataTypes;
using Dispatchment;

namespace Server
{
    internal class DataEntityFactory : IDataEntityFactory
    {
        public IDataEntity CreateEmployee(string data)
        {
            return new Employee(data);
        }
    }
}