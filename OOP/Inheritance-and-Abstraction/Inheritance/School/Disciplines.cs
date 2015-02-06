namespace School
{
    using System;
    using System.Collections.Generic;
    public class Disciplines : IDetail
    {
        private int numberLecture;
        private string disciplineName;
        private IList<Students> students;
        private string detail;

        public Disciplines(string disciplineName, int numberLecture, IList<Students> students, string detail=null)
        {
            this.DisciplineName = disciplineName;
            this.NumberLecture = numberLecture;
            this.Students = students;
            this.Detail = detail;
        }
        public IList<Students> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Students list can not be null!");
                }

                this.students = value;
            }
        }
        public int NumberLecture
        {
            get
            {
                return this.numberLecture;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Lecture must be a positive number");
                }
                this.numberLecture = value;
            }
        }
        public string DisciplineName
        {
            get
            {
                return this.disciplineName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Discipline name can not be null or empty!");
                }

                this.disciplineName = value;
            }
        }
        public string Detail
        {
            get
            {
                return this.detail;
            }

            set
            {
                this.detail = value;
            }
        }
    }
}
