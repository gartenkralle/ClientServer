using Shared.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Server.Model
{
    public class EmployeeCollection : ICollection<IEmployee>
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

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(IEmployee item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(IEmployee model)
        {
            return employees.Contains(model);
        }

        public void CopyTo(IEmployee[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IEmployee> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(IEmployee item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

