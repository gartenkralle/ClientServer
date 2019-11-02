using DataTypes;

namespace Dispatchment
{
    public interface IEmployeeServerController
    {
        bool IsExisting(IDataEntity employee);
    }
}