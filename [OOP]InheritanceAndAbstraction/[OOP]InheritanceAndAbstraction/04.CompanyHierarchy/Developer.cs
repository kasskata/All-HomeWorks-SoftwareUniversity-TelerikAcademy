using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CompanyHierarchy
{
    public class Developer : RegularEmployee
    {
        public Developer(string name, string lastName, string id, Project project)
            : base(name, lastName, id)
        {
            this.Projects = new List<Project>();
            this.Projects.Add(project);
            this.Department = Department.Production;
        }
        public List<Project> Projects { get; set; }
    }
}
