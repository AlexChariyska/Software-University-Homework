namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumber;
        private string phone;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student(string firstName,
         string lastName,
         int age,
         int facultyNumber,
         string phone,
         string email,
         List<int> marks,
         int groupNumber)
        {
         this.FirstName=firstName;
         this.LastName=lastName;
         this.Age=age;
         this.FacultyNumber = facultyNumber;
         this.Phone=phone;
         this.Email=email;
         this.Marks = marks;
         this.GroupNumber = groupNumber;
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name.");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name.");
                }
                this.lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid age.");
                }
                this.age = value;
            }
        }
        public int GroupNumber
        {
            get { return this.groupNumber; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Group number.");
                }
                this.groupNumber = value;
            }
        }  

        public List<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }   

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Faculty number.");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            string marks = String.Join(", ", this.Marks);
            string result =
                String.Format("Student: {0} {1},\nAge: {2} \nFactualy number: {3}, \nPhone: {4}, \nEmail: {5}, \nMarks: ({6}), \nGroup number: {7}\n",
                this.FirstName, this.LastName, this.Age, this.FacultyNumber, this.Phone, this.Email,
                marks, this.GroupNumber);

            return result;
        }     
    }
}
