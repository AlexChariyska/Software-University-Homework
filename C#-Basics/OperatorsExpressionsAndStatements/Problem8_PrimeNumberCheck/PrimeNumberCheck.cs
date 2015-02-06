using System;

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).

namespace Problem8_PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Insert a number below 100.");
            int num = int.Parse(Console.ReadLine());
            int check = num % 2;
            int check2 = num % 3;
            int check3 = num % 5;
            int check4 = num % 7;
            if (num > 100)
            {
                Console.WriteLine("Your number is two big.");
            }
            else if ((num == 1) || (num == 3) || (num == 5) || (num == 7))
            {
                Console.WriteLine("The number {0} is prime.", num);
            }
            else if ((check == 0) || (check2 == 0) || (check3 == 0) || (check4 == 0))
            {
                Console.WriteLine("The number {0} is not prime.", num);
            }
            else
            {
                Console.WriteLine("The number {0} is  prime.", num);
            }
        }
    }
}
