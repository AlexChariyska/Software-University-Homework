namespace School
{
    using System;
    public class People : IDetail
    {
        private string name;
        private string detail;

        public People(string name)
        {
            this.Name = name;
        }
        public People(string name, string detail):this(name)
        {
            this.Detail = detail;
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
                    throw new ArgumentNullException("Invalid input");
                }
                this.name = value;
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
        public override string ToString()
        {
            return string.Format(
                "People: {0}, Details: {1}",
                this.Name,
                this.Detail);
        }
    }
}
