using DataTypes;
using System.Collections.Generic;

namespace Server
{
    public class EmployeeController
    {
        private readonly List<Employee> employees;
        
        public EmployeeController()
        {
            employees = new List<Employee>();

            Employee employee = new Employee
            {
                ID = 2,
                Name = "Peter",
                Salary = 30000
            };

            employees.Add(employee);
        }

        public bool IsExisting(Employee employee)
        {
            return employees.Contains(employee);
        }
    }
}
