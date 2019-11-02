using SharedAbstractModel;

namespace ServerController
{
    public interface IEmployeeServerModel
    {
        bool Contains(IDataEntity employee);
    }
}