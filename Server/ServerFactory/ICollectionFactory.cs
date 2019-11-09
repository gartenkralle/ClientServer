using Shared.Model;
using System.Collections.Generic;

namespace Server.Factory
{
    public interface ICollectionFactory
    {
        ICollection<IEmployee> CreateEmployeeCollection();
    }
}