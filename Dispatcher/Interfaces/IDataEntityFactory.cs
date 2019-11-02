using SharedAbstractModel;

namespace ServerDispatchment
{
    public interface IDataEntityFactory
    {
        IDataEntity CreateEmployee(string data);
    }
}