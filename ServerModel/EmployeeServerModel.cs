using DataTypes;
using Dispatchment;
using Server;
using System.Collections.Generic;

namespace ServerModel
{
    public class EmployeeServerModel : IEmployeeServerModel
    {
        private readonly ICollection<IDataEntity> employees;

        public EmployeeServerModel()
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

        public bool Contains(IDataEntity employee)
        {
            return employees.Contains(employee);
        }
    }
}
