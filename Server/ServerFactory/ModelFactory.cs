using Server.Dispatchment;
using Shared.Model;

namespace Server.Factory
{
    public class ModelFactory : IModelFactory
    {
        public IEmployee CreateEmployee(string data)
        {
            return new Employee(data);
        }
    }
}