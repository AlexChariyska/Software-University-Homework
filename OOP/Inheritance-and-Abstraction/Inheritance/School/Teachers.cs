namespace School
{
    using System;
    using System.Collections.Generic;
    public class Teachers : People
    {
        private IList<Disciplines> disciplines;
         public Teachers(string name)
            : base(name)
        {
            this.Disciplines = new List<Disciplines>();
        }

        public Teachers(string name, List<Disciplines> disciplines)
            : this(name)
        {
            this.Disciplines = disciplines;
        }

        public Teachers(string name, List<Disciplines> disciplines, string detail)
            : this(name, disciplines)
        {
            this.Detail = detail;
        }

        public IList<Disciplines> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Disciplines", "Disciplines can not be null!");
                }

                this.disciplines = value;
            }
        }
    }
}
