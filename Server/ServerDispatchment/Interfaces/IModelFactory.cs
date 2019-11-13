using Shared.AbstractModel;

namespace Server.Dispatchment
{
    public interface IModelFactory
    {
        IEmployee CreateEmployee(string data);
    }
}