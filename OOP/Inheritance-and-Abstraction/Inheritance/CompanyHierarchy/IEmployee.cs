namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    public interface IEmployee : IPerson
    {
        double Salary { get; set; }
        DepartmentsEnum Department { get; set; }
    }
}
