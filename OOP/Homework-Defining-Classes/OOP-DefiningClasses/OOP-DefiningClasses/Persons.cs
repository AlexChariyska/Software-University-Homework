using System;


namespace OOP_DefiningClasses
{
    public class Person
    {
        //fields
        private string name;
        private string email;
        private int age;

        //Constructors

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age)
            : this(name, age, null) { }


        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input-name");
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
                if ((value >= 100) || (value <= 0))
                {
                    throw new ArgumentException("Invalid input-age");
                }
                this.age = value;
            }
        }
        public string Email 
        { 
            get
            {
                return this.email;
            }
            set
            {
                if (null != value && (value.Length == 0 || !value.Contains("@")))
                {
                    throw new ArgumentException("Invalid email!");
                }
                this.email = value;
                
            }
        }
  

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Email: {2}",
                this.Name, this.Age, this.Email);
        }
      
    }
    class Persons
    {
        static void Main(string[] args)
        {
            Person person = new Person("alex",14,"dads@da");
            Person person2 = new Person("alex", 14);
            Console.WriteLine(person.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
