using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CompanyHierarchy
{
    public abstract class RegularEmployee : Employee
    {
        public RegularEmployee(string name, string lastName, string id)
            : base(name, lastName, id)
        {
        }
    }
}
