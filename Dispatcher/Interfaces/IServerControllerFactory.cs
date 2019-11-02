using Server;

namespace Dispatchment
{
    public interface IServerControllerFactory
    {
        IEmployeeServerController CreateEmployeeServerController();
    }
}