﻿using Dispatchment;
using System.Diagnostics.CodeAnalysis;

namespace DataTypes
{
    public class Employee : IEmployee
    {
        public Employee()
        {

        }

        public Employee(string data)
        {
            string[] arr = data.Split(' ');

            ID = int.Parse(arr[0]);
            Name = arr[1];
            Salary = int.Parse(arr[2]);
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        public bool Equals([AllowNull] IEmployee other)
        {
            IEmployee employee = other as IEmployee;

            return ID == employee.ID &&
                Name == employee.Name &&
                Salary == employee.Salary;
        }

        public override string ToString()
        {
            return $"{ID} {Name} {Salary}";
        }
    }
}
