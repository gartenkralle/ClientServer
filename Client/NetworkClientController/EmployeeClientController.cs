using SharedAbstractModel;

namespace NetworkClientController
{
    public class EmployeeClientController
    {
        private readonly INetworkClient networkClient;

        public EmployeeClientController(INetworkClient networkClient)
        {
            this.networkClient = networkClient;
        }

        public bool IsExisting(IDataEntity employee)
        {
            networkClient.Send("Employee", "IsExisting", employee.ToString());

            string response = networkClient.Receive();

            return bool.Parse(response);
        }
    }
}
