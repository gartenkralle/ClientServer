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
            EmployeeController employeeController = new EmployeeController(new SocketNetwork());

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

            Console.WriteLine(employeeController.IsExisting(employee1));
            Console.WriteLine(employeeController.IsExisting(employee2));
        }
    }
}
