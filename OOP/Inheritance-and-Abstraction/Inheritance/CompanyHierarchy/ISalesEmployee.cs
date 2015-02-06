namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public interface ISalesEmployee : IRegularEmployee
    {
        IList<ISales> SalesSet { get; set; }
    }
}
