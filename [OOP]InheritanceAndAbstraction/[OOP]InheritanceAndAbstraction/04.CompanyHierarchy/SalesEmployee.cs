using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CompanyHierarchy
{
    public class SalesEmployee : RegularEmployee
    {
        public SalesEmployee(string name, string lastName, string id, Sale sale)
            : base(name, lastName, id)
        {
            this.Sales = new List<Sale>();
            this.Sales.Add(sale);
            this.Department = Department.Sales;
        }
        public List<Sale> Sales { get; set; }
    }
}
