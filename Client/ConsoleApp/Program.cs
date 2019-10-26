using DataTypes;
using System;
using TcpIp_Extended;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            NetworkClientController networkController = new NetworkClientController(new NetworkClient(new ConcreteNetworkClient()));

            Console.WriteLine(networkController.IsExisting(new Employee
            {
                ID = 1,
                Name = "Peter",
                Salary = 30000
            }));

            Console.WriteLine(networkController.IsExisting(new Employee
            {
                ID = 2,
                Name = "Peter",
                Salary = 30000
            }));
        }
    }
}
