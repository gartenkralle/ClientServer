using Shared.Model;

namespace Server.Dispatchment
{
    public interface IModelFactory
    {
        IEmployee CreateEmployee(string data);
    }
}