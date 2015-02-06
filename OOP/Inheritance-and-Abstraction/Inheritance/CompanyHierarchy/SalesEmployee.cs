
namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private IList<ISales> salesSet;

        public SalesEmployee(string fName, string lName, int id, double salary, DepartmentsEnum department, IList<ISales> salesSet)
            : base(fName, lName, id, salary, department)
        {
            this.SalesSet = salesSet;
        }
        public IList<ISales> SalesSet
        {
            get
            {
                return this.salesSet;
            }
            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException( "Sales can not be null!");
                }
                this.salesSet = value;
            }
        }
        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format("\nSales: \n{0}", string.Join("\n", this.salesSet));
        }
    }
}
