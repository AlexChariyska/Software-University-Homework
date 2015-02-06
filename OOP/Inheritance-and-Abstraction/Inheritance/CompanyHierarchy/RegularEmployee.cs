using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class RegularEmployee : Employee, IRegularEmployee
    {
        public RegularEmployee(string fName, string lName, int id, double salary, DepartmentsEnum department)
            : base( fName, lName,id, salary, department)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
