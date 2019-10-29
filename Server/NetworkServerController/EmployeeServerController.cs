using AbstractDataTypes;
using DataTypes;
using System.Collections.Generic;

namespace Server
{
    public class EmployeeServerController
    {
        private readonly ICollection<IDataEntity> employees;
        
        public EmployeeServerController()
        {
            employees = new List<IDataEntity>();

            IDataEntity employee = new Employee
            {
                ID = 2,
                Name = "Peter",
                Salary = 30000
            };

            employees.Add(employee);
        }

        public bool IsExisting(IDataEntity employee)
        {
            return employees.Contains(employee);
        }
    }
}
