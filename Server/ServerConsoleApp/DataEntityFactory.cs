using DataTypes;
using Dispatchment;

namespace Server
{
    internal class DataEntityFactory : IDataEntityFactory
    {
        public IEmployee CreateEmployee(string data)
        {
            return new Employee(data);
        }
    }
}