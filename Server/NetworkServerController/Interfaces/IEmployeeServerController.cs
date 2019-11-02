using SharedAbstractModel;

namespace ServerController
{
    public interface IEmployeeServerController
    {
        bool IsExisting(IDataEntity employee);
    }
}