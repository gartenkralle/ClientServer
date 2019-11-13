using Server.Controller;
using Shared.AbstractModel;
using Shared.Model;
using System.Collections.Generic;

namespace Server.Model
{
    public class EmployeeCollection : IEmployeeCollection
    {
        private readonly ICollection<IEmployee> employees;

        public EmployeeCollection()
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

        public bool Contains(IEmployee model)
        {
            return employees.Contains(model);
        }
    }
}

