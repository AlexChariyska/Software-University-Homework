using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that calculates all prime numbers in given range and returns them as list of integers:

class PrimeChecker
{
    static void Main()
    {
        Console.WriteLine("Insert the number n:");
        int number = int.Parse(Console.ReadLine());
        IsPrime(number);
    }

    static void IsPrime(int number)
    {
        bool result = true;
        if (number == 0 || number == 1)
        {
        result = false;
        }
        else
        {
            for (int a = 2; a <= number / 2; a++)
            {
                if (number % a == 0)
                {
                    result = false;
                }

            }
            Console.WriteLine(result);
        }
    }
}

