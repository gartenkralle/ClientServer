using System;
using DataTypes;
using TcpIp_Extended;

namespace Client
{
    public class EmployeeClientController
    {
        private readonly INetworkClient networkClient;

        public EmployeeClientController(INetworkClient networkClient)
        {
            this.networkClient = networkClient;
        }

        public bool IsExisting(Employee employee)
        {
            networkClient.Send(nameof(Employee), nameof(IsExisting), employee.ToString());

            string response = networkClient.Receive();

            return bool.Parse(response);
        }
    }
}
