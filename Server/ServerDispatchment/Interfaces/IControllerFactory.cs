using Server.Controller;

namespace Server.Dispatchment
{
    public interface IControllerFactory
    {
        IEmployeeController CreateEmployeeController();
    }
}