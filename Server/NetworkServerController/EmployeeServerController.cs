﻿using Dispatchment;

namespace Server
{
    public class EmployeeServerController : IEmployeeServerController
    {
        private readonly IEmployeeServerModel employeeModel;

        public EmployeeServerController(IEmployeeServerModel employeeModel)
        {
            this.employeeModel = employeeModel;
        }

        public bool IsExisting(IEmployee employee)
        {
            return employeeModel.Contains(employee);
        }
    }
}
