namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SetOFDisciplines 
    {
        IList<Disciplines> setDisciplines;
        public SetOFDisciplines(IList<Disciplines> setOfDisciplines)
        {
            this.SetDisciplines=setOfDisciplines;
        }
        public IList<Disciplines> SetDisciplines
        {
            get
            {
                return this.setDisciplines;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Disciplines", "Disciplines can not be null!");
                }

                this.setDisciplines = value;
            }
        }
    }
}
