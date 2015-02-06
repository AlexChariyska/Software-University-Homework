
namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Classes
    {
        private static IList<string> uniqueIds;

        private string uniqueId;
        private IList<Teachers> teachers;
        private IList<Students> students;
        private string detail;

        static Classes()
        {
            Classes.uniqueIds = new List<string>();
        }

        public Classes(string uniqueId, IList<Students> students, IList<Teachers> teachers)
        {
            this.UniqueId = uniqueId;
            this.Teachers = teachers;
            this.Students = students;
            Classes.uniqueIds.Add(uniqueId);
        }

        public string UniqueId
        {
            get
            {
                return this.uniqueId;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("UniqueId", "UniqueId can not be null or empty!");
                }

                if (uniqueIds.Contains(value))
                {
                    throw new ArgumentException("There is another class with this identification!");
                }

                this.uniqueId = value;
            }
        }

        public IList<Teachers> Teachers
        {
            get
            {
                return this.teachers;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Teachers", "Teachers can not be null");
                }

                this.teachers = value;
            }
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
                    throw new ArgumentNullException("Students", "Students can not be null");
                }

                this.students = value;
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
