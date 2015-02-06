namespace HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    class Worker : Human
    {
        const int DaysPerWeek = 5;
        private double weekSalary;
        private int workHoursPerDay;

        public Worker(string fName, string lName)
            : base(fName, lName)
        {
        }
        public Worker(string fName, string lName, double weekSalary, int workHoursPerDay)
            : this(fName, lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary 
        {
            get 
            {
                return this.weekSalary;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work Hours Per Day must be positive number");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("Work Hours Per Day must be positive number");
                }
                this.workHoursPerDay = value;
            }
        }
        public double MoneyPerHour( int workHoursPerDay)
        {
            double result = this.WeekSalary / (DaysPerWeek * workHoursPerDay);
            return result;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format(
                " Weekly salary: {0:N2}, daily work hours: {0:N2}",
                this.WeekSalary,
                this.WorkHoursPerDay);
        }
    }
}
