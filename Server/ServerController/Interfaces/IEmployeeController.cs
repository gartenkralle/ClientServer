using Shared.AbstractModel;

namespace Server.Controller
{
    public interface IEmployeeController
    {
        bool IsExisting(IEmployee employee);
    }
}