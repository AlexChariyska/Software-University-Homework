
namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public interface ISales
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        double Price { get; set; }
    }
}
