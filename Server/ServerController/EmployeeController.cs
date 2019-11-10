using Server.Model;
using Shared.Model;
using System.Collections.Generic;

namespace Server.Controller
{
    public class EmployeeController : IEmployeeController
    {
        private readonly EmployeeCollection employeeModel;

        public EmployeeController(EmployeeCollection employeeModel)
        {
            this.employeeModel = employeeModel;
        }

        public bool IsExisting(IEmployee employee)
        {
            return employeeModel.Contains(employee);
        }
    }
}
