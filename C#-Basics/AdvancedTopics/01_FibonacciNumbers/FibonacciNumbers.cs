using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a method Fib(n) that calculates the nth Fibonacci number. 

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert the number n:");
        int number = int.Parse(Console.ReadLine());
        Fib(number);
    }

    static void Fib(int number)
    {
        int firstNum = 0;
        int secondNum = 1;
        int themp;
        if (number == 1)
        {
            Console.WriteLine("0");
        }
        else if (number == 2)
        {
            Console.WriteLine("1");
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                themp = firstNum;
                firstNum = secondNum;
                secondNum = themp + secondNum;
            }
            Console.WriteLine(secondNum);
        }
    }
}



