using TcpServer;

namespace Dispatchment
{
    internal static class Type
    {
        internal const string Employee = "Employee";
    }

    internal static class Function
    {
        internal const string IsExisting = "IsExisting";
    }

    public class Dispatcher
    {
        private readonly IServerControllerFactory serverControllerFactory;
        private readonly IDataEntityFactory dataEntityFactory;

        public Dispatcher(IServerControllerFactory serverControllerFactory, IDataEntityFactory dataEntityFactory)
        {
            this.serverControllerFactory = serverControllerFactory;
            this.dataEntityFactory = dataEntityFactory;
        }

        public string Dispatch(string request)
        {
            string response = null;

            Request requestEntity = new Request(request);

            if (requestEntity.Type == Type.Employee)
            {
                IEmployeeServerController employeeServerController = serverControllerFactory.CreateEmployeeServerController();

                if (requestEntity.Function == Function.IsExisting)
                {
                    response = employeeServerController.IsExisting(dataEntityFactory.CreateEmployee(requestEntity.Data)).ToString();
                }
            }

            return response;
        }
    }
}
