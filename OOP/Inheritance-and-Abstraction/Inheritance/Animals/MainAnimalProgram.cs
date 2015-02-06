namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainAnimalProgram
    {
        static void Main()
        {
            Animals frog = new Frog("Ginka", 1, "Female");
            Animals frog2 = new Frog("Gincho", 3, "Male");

            Animals sharo = new Dogs("Sharo", 3, "Male");
            Animals luki = new Dogs("Luki", 2, "Female");
            Animals bu = new Dogs("Bu", 10, "Male");

            Animals puhi = new Kitten("puhi", 2);
            Animals tom = new Tomcat("Tom", 4);
            Animals muke = new Cat("Muke", 5, "Male");

            frog.ProduceSound();
            Console.WriteLine();

            List<Animals> animals = new List<Animals>()
            {
                frog,
                frog2,
                sharo,
                luki,
                puhi,
                tom,
                muke,
                bu
            };

            var listedAnimals = from anim in animals
                                group anim by anim.GetType() into groupAnim
                                select new { GroupName = groupAnim.Key, AverageAge = groupAnim.ToList().Average(an => an.Age) };
            
            foreach (var animal in listedAnimals)
            {
                Console.WriteLine("{0} - Average age: {1:N2}", animal.GroupName.Name, animal.AverageAge);
            }
        }
    }
}
