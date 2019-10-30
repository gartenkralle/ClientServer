using Client;
using DataTypes;
using System;
using TcpIp_Extended;

namespace ConsoleApp
{
    class ClientProgram
    {
        static void Main()
        {
            EmployeeClientController employeeClientController = new EmployeeClientController(new NetworkClient(new SocketNetworkClient()));

            Console.WriteLine(employeeClientController.IsExisting(new Employee
            {
                ID = 1,
                Name = "Peter",
                Salary = 30000
            }));

            Console.WriteLine(employeeClientController.IsExisting(new Employee
            {
                ID = 2,
                Name = "Peter",
                Salary = 30000
            }));
        }
    }
}
