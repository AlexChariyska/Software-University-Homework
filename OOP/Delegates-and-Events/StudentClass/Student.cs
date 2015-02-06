namespace StudentClass
{
    using System;
    public class Student
    {
        private int age;
        private string name;

        public event EventHandler<PropertyChangedEvent<string>> PropertyChanged;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                { 
                    throw new ArgumentNullException("Please enter a name");
                }
                this.OnPropertyChanged(new PropertyChangedEvent<string>("Name", this.name, value));
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (age <= 0 )
                {
                    throw new ArgumentOutOfRangeException("Please enter a valid age"); 
                }
                this.OnPropertyChanged(new PropertyChangedEvent<string>("Age", this.Age.ToString(), value.ToString()));
                age = value;
            }
        }
        public Student(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        protected virtual void OnPropertyChanged(PropertyChangedEvent<string> e)
        {
            if (null != this.PropertyChanged)
            {
                this.PropertyChanged(this, e);
            }
        }

    }
}
