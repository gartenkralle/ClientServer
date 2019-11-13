using Shared.AbstractModel;

namespace Server.Controller
{
    public interface IEmployeeCollection
    {
        bool Contains(IEmployee employee);
    }
}
