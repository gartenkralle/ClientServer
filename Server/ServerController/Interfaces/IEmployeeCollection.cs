using Shared.Model;

namespace Server.Controller
{
    public interface IEmployeeCollection
    {
        bool Contains(IEmployee employee);
    }
}
