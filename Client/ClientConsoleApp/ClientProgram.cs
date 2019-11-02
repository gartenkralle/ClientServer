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
            EmployeeClientController employeeClientController = new EmployeeClientController(new SocketNetworkClient());

            Employee employee1 = new Employee
            {
                ID = 1,
                Name = "Peter",
                Salary = 30000
            };

            Employee employee2 = new Employee
            {
                ID = 2,
                Name = "Peter",
                Salary = 30000
            };

            Console.WriteLine(employeeClientController.IsExisting(employee1));
            Console.WriteLine(employeeClientController.IsExisting(employee2));
        }
    }
}
