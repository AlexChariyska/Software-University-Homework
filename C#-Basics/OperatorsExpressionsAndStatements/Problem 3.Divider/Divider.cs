using System;

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

namespace Problem_3.Divider
{
    class Divider
    {
        static void Main()
        {
            Console.WriteLine("Insert a number:");
            int number = int.Parse(Console.ReadLine());
            int divider7 = number % 7;
            int divider5 = number % 5;
            bool result = ((divider7 == 0) && (divider5 == 0) && (number != 0));
            Console.WriteLine(result);
        }
    }
}
