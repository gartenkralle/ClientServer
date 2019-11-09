using Server.Controller;

namespace Server.Dispatchment
{
    public class Dispatcher
    {
        private readonly IControllerFactory serverControllerFactory;
        private readonly IModelFactory modelFactory;

        public Dispatcher(IControllerFactory serverControllerFactory, IModelFactory modelFactory)
        {
            this.serverControllerFactory = serverControllerFactory;
            this.modelFactory = modelFactory;
        }

        public string Dispatch(string request)
        {
            string response = null;

            Request requestEntity = new Request(request);

            if (requestEntity.Type == Type.Employee)
            {
                IEmployeeController employeeController = serverControllerFactory.CreateEmployeeController();

                if (requestEntity.Function == Function.IsExisting)
                {
                    response = employeeController.IsExisting(modelFactory.CreateEmployee(requestEntity.Data)).ToString();
                }
            }

            return response;
        }
    }
}
