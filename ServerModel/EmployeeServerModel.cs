using DataTypes;
using Dispatchment;
using Server;
using System.Collections.Generic;

namespace ServerModel
{
    public class EmployeeServerModel : IEmployeeServerModel
    {
        private readonly ICollection<IEmployee> employees;

        public EmployeeServerModel()
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

        public bool Contains(IEmployee employee)
        {
            return employees.Contains(employee);
        }
    }
}
