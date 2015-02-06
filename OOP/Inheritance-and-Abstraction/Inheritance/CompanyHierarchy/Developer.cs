using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Developer : RegularEmployee, IDeveloper
    {
        IList<IProject> projects;

        public Developer(string firstName, string lastName, int id, double salary, DepartmentsEnum department, IList<IProject> projects)
            : base(firstName, lastName,id, salary, department)
        {
            this.Projects = projects;
        }

        public IList<IProject> Projects
        {
            get
            {
                return this.projects;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Projects can not be null!");
                }

                this.projects = value;
            }
        }
        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format("\nProjects: \n{0}", string.Join("\n", this.Projects));
        }

    }
}
