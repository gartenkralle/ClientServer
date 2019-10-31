using AbstractDataTypes;

namespace Server
{
    public interface IEmployeeServerModel
    {
        bool Contains(IDataEntity employee);
    }
}