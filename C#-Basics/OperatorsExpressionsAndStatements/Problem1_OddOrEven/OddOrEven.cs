using System;

namespace Problem1_OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            //Write an expression that checks if given integer is odd or even

            Console.WriteLine("Insert a number:");
            int number = int.Parse(Console.ReadLine());
            int result = number % 2;
            if (result == 0)
            {
                Console.WriteLine("Number is even.");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
