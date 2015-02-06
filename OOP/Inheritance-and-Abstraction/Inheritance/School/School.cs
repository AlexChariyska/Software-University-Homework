namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class School
    {
        public static void Main()
        {
            Students anna = new Students("Anna", 201122345, "Age 19");
            Students gosho = new Students("Gosho", 123456789);
            Students petko = new Students("Petko", 201122380);


            Disciplines maths = new Disciplines("Mathematics", 4,new List<Students>() { anna, gosho, petko });
            Disciplines litterature = new Disciplines("Litterature",5, new List<Students>() { gosho, petko });

            Teachers petrova = new Teachers("Petrova", new List<Disciplines>() { litterature });
            Teachers ivanov = new Teachers("Ivanov", new List<Disciplines>() { maths, litterature });

            Classes class2011 = new Classes("2011",new List<Students>() { anna, gosho }, new List<Teachers>() { petrova });


            Classes class1213 = new Classes("1213", new List<Students>() { petko, gosho }, new List<Teachers>() { ivanov });

        }
    }
}
