using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CompanyHierarchy
{
    public class Manager : Employee
    {
        public Manager(string name, string lastName, string id, Employee employee)
            : base(name, lastName, id)
        {
            this.Employees = new List<Employee>();
            this.Employees.Add(employee);
            this.Department = Department.Accounting;
        }
        public List<Employee> Employees { get; set; }
    }
}
