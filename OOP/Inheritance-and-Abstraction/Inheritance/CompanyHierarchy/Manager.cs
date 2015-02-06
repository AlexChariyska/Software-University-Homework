using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Manager : Employee, IManager
    {
        private IList<IEmployee> setOfEmployees;
        public Manager(string fName, string lName, int id, double salary, DepartmentsEnum department, IList<IEmployee> setOfEmployees)
            : base(fName, lName, id, salary, department)
        {
            this.SetOfEmployees = setOfEmployees;
        }
        public IList<IEmployee> SetOfEmployees
        {
            get
            {
                return this.setOfEmployees;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Employees can not be null!");
                }

                this.setOfEmployees = value;
            }
        }
        public override string ToString()
        {
            string baseStr = base.ToString();
            string employeesStr = string.Empty;

            foreach (var employee in this.setOfEmployees)
            {
                employeesStr += employee.FName + " " + employee.LName + ", " + employee.Id;
            }

            return baseStr + string.Format("\nManaged employees: {0}", employeesStr);
        }
    }
}
