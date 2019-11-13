using System;

namespace Shared.AbstractModel
{
    public interface IEmployee : IEquatable<IEmployee>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
