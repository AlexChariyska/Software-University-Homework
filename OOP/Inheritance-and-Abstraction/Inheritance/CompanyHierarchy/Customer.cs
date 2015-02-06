
namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Customer : Person, ICustomer
    {
        private double netPurchaseAmount;
        public Customer(string fName, string lName,int id)
            : base(fName, lName, id)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }
        public double NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                this.netPurchaseAmount = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("{0:N2}", this.NetPurchaseAmount);
        }
    }
}
