using AbstractDataTypes;

namespace Server
{
    public class EmployeeServerController
    {
        private readonly IEmployeeServerModel employeeModel;

        public EmployeeServerController(IEmployeeServerModel employeeModel)
        {
            this.employeeModel = employeeModel;
        }

        public bool IsExisting(IDataEntity employee)
        {
            return employeeModel.Contains(employee);
        }
    }
}
