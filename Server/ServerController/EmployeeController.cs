using Shared.Model;
using System.Collections.Generic;

namespace Server.Controller
{
    public class EmployeeController : IEmployeeController
    {
        private readonly ICollection<IEmployee> employeeModel;

        public EmployeeController(ICollection<IEmployee> employeeModel)
        {
            this.employeeModel = employeeModel;
        }

        public bool IsExisting(IEmployee employee)
        {
            return employeeModel.Contains(employee);
        }
    }
}
