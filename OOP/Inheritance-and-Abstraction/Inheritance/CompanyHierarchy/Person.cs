namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    public abstract class Person : IPerson
    {
        private string fName;
        private string lName;
        private int id;

        public Person(string fName, string lName, int id)
        {
            this.fName = fName;
            this.LName = lName;
            this.Id = id;
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Age can not be negative!");
                }
                id = value;
            }
        }

        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can not be null or empty!");
                }
                fName = value;
            }
        }
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can not be null or empty!");
                }
                lName = value;
            }
        }
        public override string ToString()
        {
            return string.Format("ID: {0}\nFirst Name: {1}\nLast Name: {2}", this.Id, this.FName, this.LName);
        }
    }
}
