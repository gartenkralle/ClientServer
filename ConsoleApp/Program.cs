using DataTypes;
using System;
using TcpIp_Extended;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            NetworkController networkController = new NetworkController(new NetworkClient(new ConcreteNetworkClient()));

            Console.WriteLine(networkController.IsExisting(new Employee
            {
                ID = 1,
                Name = "Peter",
                Salary = 30000
            }));
        }
    }
}
