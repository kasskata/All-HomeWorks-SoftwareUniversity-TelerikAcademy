using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CompanyHierarchy
{
    public class Project
    {
        private string projectName;
        private DateTime projectStart;
        private bool state = true;
        public Project(string name, DateTime time, string details)
        {
            this.State = true;
            this.ProjectName = name;
            this.ProjectStart = time;
            this.Details = details;
        }

        public bool State { get; private set; }

        public string ProjectName
        {
            get
            {
                if (string.IsNullOrEmpty(this.projectName))
                {
                    throw new ArgumentNullException("Cant be null");
                }
                return this.projectName;
            }
            protected set
            {
            }
        }

        public DateTime ProjectStart
        {
            get
            {
                return this.projectStart;
            }
            private set
            {
            }
        }

        public string Details { get; set; }

        public void CloseProject()
        {
            if (this.state == true)
            {
                this.State = false;
                this.state = false;
            }
        }
    }
}
