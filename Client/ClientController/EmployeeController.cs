using Shared.Model;

namespace Client.Controller
{
    public class EmployeeController
    {
        private readonly INetwork networkClient;

        public EmployeeController(INetwork networkClient)
        {
            this.networkClient = networkClient;
        }

        public bool IsExisting(IEmployee employee)
        {
            networkClient.Send("Employee", "IsExisting", employee.ToString());

            string response = networkClient.Receive();

            return bool.Parse(response);
        }
    }
}
