using System;

    class EmployeeData
    {
        static void Main()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your age name:");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter your gender:");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter your ID number:");
            int numberID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your employee number:");
            int employeeNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Employee's name is {0} {1}, with ID number {2},age {3},gender {4}.Employee number: {5}",
                firstName, lastName, numberID, age, gender, employeeNum);
        }
    }
