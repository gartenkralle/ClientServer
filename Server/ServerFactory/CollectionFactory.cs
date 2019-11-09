using Server.Model;
using Shared.Model;
using System.Collections.Generic;

namespace Server.Factory
{
    public class CollectionFactory : ICollectionFactory
    {
        public ICollection<IEmployee> CreateEmployeeCollection()
        {
            return new EmployeeCollection();
        }
    }
}