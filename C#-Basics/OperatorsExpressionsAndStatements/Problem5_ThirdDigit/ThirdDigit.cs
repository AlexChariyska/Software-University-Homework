using System;

//Write an expression that checks for given integer if its third digit from right-to-left is 7

namespace Problem5_ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            Console.WriteLine("Insert a number:");
            int number = int.Parse(Console.ReadLine());
            number = number / 100;
            int digit = number % 10;
            bool check = (digit == 7);
            Console.WriteLine(check);
        }
    }
}
