
namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Employee :Person, IEmployee
    {
        private double salary;
        private DepartmentsEnum department;

        public Employee(string fName, string lName, int id, double salary, DepartmentsEnum department)
            : base( fName,  lName,  id)
        {
            this.Salary = salary;
            this.Department = department;
        }
        public DepartmentsEnum Department 
        {
            get
            {
                return this.department;
            }

            set
            {
                this.department = value;
            }
        }
        public double Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (0 > (value))
                {
                    throw new ArgumentException("The salary can not be less than 0");
                }
                this.salary = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Employee:{2} {3}\nSalary: {0}\nDepartment: {1}", this.Salary, this.Department, this.FName,this.LName);
        }
    }
}
