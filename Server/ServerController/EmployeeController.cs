using Shared.AbstractModel;

namespace Server.Controller
{
    public class EmployeeController : IEmployeeController
    {
        private readonly IEmployeeCollection employeeModel;

        public EmployeeController(IEmployeeCollection employeeModel)
        {
            this.employeeModel = employeeModel;
        }

        public bool IsExisting(IEmployee employee)
        {
            return employeeModel.Contains(employee);
        }
    }
}
