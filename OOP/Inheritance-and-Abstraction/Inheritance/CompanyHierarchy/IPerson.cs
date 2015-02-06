namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IPerson
    {
        int Id { get; set; }

        string FName { get; set; }

        string LName { get; set; }
    }

}
