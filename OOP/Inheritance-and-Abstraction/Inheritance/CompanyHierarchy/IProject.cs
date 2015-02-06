namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IProject
    {
        string ProjectName { get; set; }
        string ProjectStartDate { get; set; }
        string Details { get; set; }
        State State { get; set; }
    }
}
