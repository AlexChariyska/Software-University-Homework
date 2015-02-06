namespace HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class MainProgram
    {
        static void Main()
        {
            Student pesho = new Student("Pesho", "Petrov", "20144567");
            Student gosho = new Student("Gosho", "Georgiev", "20141730");
            Student misho = new Student("Misho", "Mishev", "20142589");
            Student anna = new Student("Anna", "Ivanova", "20146547");
            Student may = new Student("Maq", "Gancheva", "20145285");
            Student ivan = new Student("Ivan", "Ivanov", "20145687");
            Student dimitar = new Student("Dimitar", "Dimitrov", "20143698");
            Student damyan = new Student("Damyan", "Damyanov", "20149634");
            Student kiril = new Student("Kiril", "Dimitrov", "20147415");
            Student doncho = new Student("Doncho", "Donchev", "20145612");

            List<Student> students = new List<Student>()
            {
                pesho,
                gosho,
                misho,
                anna,
                may,
                ivan,
                dimitar, 
                damyan,
                kiril,
                doncho
            };

            Worker kiril2 = new Worker("Kiril", "Kostadinov", 282, 8);
            Worker sancho = new Worker("Sancho", "Pansa", 382, 6);
            Worker penka = new Worker("Penka", "Kostadinova", 243.2, 4);
            Worker dimitrichka = new Worker("Dimitrichka", "Doynova", 150.40, 8);
            Worker marina = new Worker("Marina", "Marinva", 182, 6);
            Worker zlatomir = new Worker("Zlatomir", "Zlatev", 240, 4);
            Worker petar = new Worker("Petar", "Donchev", 1000, 4);
            Worker pencho = new Worker("Pencho", "Penchev", 650, 8);
            Worker marko = new Worker("Marko", "Markov", 480, 9);
            Worker kostadin = new Worker("Kostadin", "Haralambov", 670.50, 9);

            List<Worker> workers = new List<Worker>()
            {
                kiril2,
                sancho,
                penka,
                dimitrichka,
                marina,
                zlatomir,
                petar,
                pencho,
                marko,
                kostadin
            };

            Console.WriteLine("Sorted Students:");
            var sortedStudents = students.OrderBy(st => st.FacultyNumber);
            foreach (var st in sortedStudents)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("\n \n Sorted Workers: ");
            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour(5));
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker + string.Format(" Hourly rate: {0:N2}", worker.MoneyPerHour(5)));
            }

            Console.WriteLine("\nSorted Humans: ");
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            var sortedHumans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
