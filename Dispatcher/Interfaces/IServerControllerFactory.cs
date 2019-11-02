using ServerController;

namespace ServerDispatchment
{
    public interface IServerControllerFactory
    {
        IEmployeeServerController CreateEmployeeServerController();
    }
}