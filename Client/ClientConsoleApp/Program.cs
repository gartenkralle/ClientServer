using System;
using Client.Controller;
using Client.Network;
using Shared.Model;

namespace Client.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            INetwork network = new SocketNetwork();
            EmployeeController employeeController = new EmployeeController(network);

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

            network.Connect();

            Console.WriteLine(employeeController.IsExisting(employee1));
            Console.WriteLine(employeeController.IsExisting(employee2));

            network.Disconnect();
        }
    }
}
