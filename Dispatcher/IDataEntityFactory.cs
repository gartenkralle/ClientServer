namespace Dispatchment
{
    public interface IDataEntityFactory
    {
        IEmployee CreateEmployee(string data);
    }
}