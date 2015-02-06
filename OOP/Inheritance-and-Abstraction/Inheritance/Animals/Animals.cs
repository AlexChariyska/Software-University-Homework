namespace Animals
{
    using System;
    using System.Collections.Generic;
    public abstract class Animals
    {
        private string name;
        private int age;
        private string gender;

        public Animals(string name, int age, string gender)
        {
            this.Name=name;
            this.Age=age;
            this.Gender=gender;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("Invalid age");
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Gender cannot be null");
                }
                this.gender = value;
            }
        }
        public abstract void ProduceSound();
        public override string ToString()
        {
            return string.Format("Animal of type: {0}, age: {1}, gender: {3}", GetType(), this.Age, this.Gender);
        }
    }
}
