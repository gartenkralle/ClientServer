using DataTypes;
using System.Collections.Generic;

namespace Server
{
    public class EmployeeController
    {
        private readonly ICollection<IEmployee> employees;
        
        public EmployeeController()
        {
            employees = new List<IEmployee>();

            IEmployee employee = new Employee
            {
                ID = 2,
                Name = "Peter",
                Salary = 30000
            };

            employees.Add(employee);
        }

        public bool IsExisting(IEmployee employee)
        {
            return employees.Contains(employee);
        }
    }
}
