namespace School
{
    using System;
    using System.Collections.Generic;

    public class Students : People
    {
        private static IList<int> takenClassNumbers;
        private int classNumber;

        static Students()
        {
            Students.takenClassNumbers = new List<int>();
        }

        public Students(string name, int classNumber)
            : base(name)
        {
            this.UniqueClassNumber = classNumber;
            Students.takenClassNumbers.Add(classNumber);
        }

        public Students(string name, int classNumber, string detail)
            : this(name, classNumber)
        {
            this.Detail = detail;
        }

        public int UniqueClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                if (takenClassNumbers.Contains(value))
                {
                    throw new ArgumentException("The class number was assigned to another student");
                }
                this.classNumber = value;
            }
        }
    }
}
