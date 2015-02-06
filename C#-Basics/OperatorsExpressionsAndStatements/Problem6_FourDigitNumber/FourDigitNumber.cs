using System;

//Write a program that takes as input a four-digit number in format abcd.

namespace Problem6_FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Insert a four digit number:");
            int number = int.Parse(Console.ReadLine());
            int digit1 = number % 10;
            int digit2 = (number / 10) % 10;
            int digit3 = (number / 100) % 10;
            int digit4 = (number / 1000);
            int sum = digit1 + digit2 + digit3 + digit4;
            Console.WriteLine("The sum is: {0}.", sum);
            Console.WriteLine("Reverse order: {0}{1}{2}{3}.", digit1, digit2, digit3, digit4);
            Console.WriteLine("Exchange first and last position: {0}{1}{2}{3}.",
                digit1, digit3, digit2, digit4);
            Console.WriteLine("Exchange second and third digit: {0}{1}{2}{3}",
                digit4, digit2, digit3, digit1);
        }
    }
}
