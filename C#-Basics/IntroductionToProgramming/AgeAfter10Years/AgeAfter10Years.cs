using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Please insert your birht year:");
        int yearBirth = int.Parse(Console.ReadLine());
        int yearNow = DateTime.Now.Year;
        int age = yearNow - yearBirth;
        int newAge = age + 10; 
        Console.WriteLine("Your age after 10 years will be: {0}.", newAge);
    }
}

