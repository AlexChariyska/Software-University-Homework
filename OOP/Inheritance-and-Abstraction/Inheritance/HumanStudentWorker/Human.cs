namespace HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    public abstract class Human
    {
        private string fName;
        private string lName;

        public Human(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public string LastName
        {
            get
            {
                return this.lName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException( "LastName can not be null or empty!");
                }

                this.lName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.fName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("FirstName can not be null or empty!");
                }

                this.fName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}", this.FirstName, this.LastName);
        }

    }
}
