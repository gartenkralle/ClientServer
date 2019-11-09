using Shared.Model;

namespace Server.Controller
{
    public interface IEmployeeController
    {
        bool IsExisting(IEmployee employee);
    }
}