namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class StudentsMain
    {
        static void Main()
        {
            string star = new String('*', 50);

            Student petur =
                new Student("Petur", "Qnkov", 23, 10111400, "088451245",
                    "pesho_qnkov@abv.bg", new List<int>() { 4, 5, 6, 3, 6, 6, 6 }, 1);
            Student vlado =
                new Student("Vlado", "Angelov", 19, 13118795, "359885522119",
                    "valdo.angelov@gmail.com", new List<int>() { 2, 2, 2, 2, 2, 3, 4 }, 2);
            Student stoqn =
                new Student("Stoqn", "Stoqnov", 33, 10111434, "+359279542357",
                    "stoqn@abv.bg", new List<int>() { 6, 6, 6, 6, 6, 6, 6 }, 2);
            Student kiril =
                new Student("Kiril", "Dimitrov", 20, 12119874, "+359 0088877",
                    "kiro@abv.bg", new List<int>() { 6, 6, 4, 6, 4, 2, 3 }, 4);
            Student pesho =
                new Student("Pesho", "Peshov", 18, 14124568, "020011111",
                    "pesho@gmail.com", new List<int>() { 5, 2, 4, 6, 4, 2, 3 }, 3);

            List<Student> students = new List<Student>();
            students.Add(petur);
            students.Add(stoqn);
            students.Add(vlado);
            students.Add(kiril);
            students.Add(pesho);

            var studentsByGroup = from st in students
                                  where st.GroupNumber == 2
                                  orderby st.FirstName
                                  select st;
            Console.WriteLine("Student by Group: \n");

            foreach (var item in studentsByGroup)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(star);

            var studentsByName = from st in students
                                 where string.Compare(st.FirstName, st.LastName) < 0
                                 select st;
            Console.WriteLine("Student by First and last name: \n");

            foreach (var item in studentsByName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(star);

            var studentsByAge = from st in students
                                where (st.Age < 24 && st.Age > 18)
                                select st;
            Console.WriteLine("Student by Age: \n");

            foreach (var item in studentsByAge)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
            }

            Console.WriteLine(star);

            var studentsSort = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);

            var studentsDescendingOrderLINQ =
            from st in students
            orderby st.FirstName descending, st.LastName descending
            select st;

            Console.WriteLine("Sort Student descending: \n");

            foreach (var item in studentsSort)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(star);

            var studentsSortByEmail = from st in students
                                      where st.Email.EndsWith("@abv.bg")
                                      select st;

            Console.WriteLine("Sort Student by email: \n");

            foreach (var item in studentsSortByEmail)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(star);

            var studentsSortByPhone = from st in students
                                      where st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592") || st.Phone.StartsWith("+359 2")
                                      select st;

            Console.WriteLine("Sort Student by phone: \n");

            foreach (var item in studentsSortByPhone)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(star);

            var studentExcellent = from st in students
                                   where st.Marks.Contains(6)
                                   select new { FirstName = st.FirstName, LastName = st.LastName, Marks = st.Marks };

            Console.WriteLine("Excellent Students: \n");

            foreach (var item in studentExcellent)
            {
                string marks = string.Join(" ", item.Marks);
                Console.WriteLine("{0} {1}: ({2})", item.FirstName, item.LastName, marks);
            }

            Console.WriteLine(star);

            var weakStudents = from st in students
                               where st.Marks.Where(s => s == 2).Count() == 2
                               select st;
            Console.WriteLine("Weak Students: \n");

            foreach (var item in weakStudents)
            {
                string marks = string.Join(" ", item.Marks);
                Console.WriteLine("{0} {1}: ({2})", item.FirstName, item.LastName, marks);
            }

            Console.WriteLine(star);

            var studentsEnrolled = students.Where(s => s.FacultyNumber.ToString().Substring(4, 2) == "14");

            Console.WriteLine("Students enrolled in 2014: \n");

            foreach (var item in studentsEnrolled)
            {
                Console.WriteLine(item);
            }
        }
    }
}
