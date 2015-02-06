using System;

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert a number n:");
        int num = int.Parse(Console.ReadLine());
        int fibonacciNum;
        int startNum = 0;
        int secondNum = 1;
        if (num == 1)
        {
            Console.WriteLine(0);
        }
        else if (num == 0)
        {
            Console.WriteLine("There is no sequence.");
        }
        else
        {
            Console.Write(0 + ", " + 1 + ", ");
            for (int i = 0; i < num-2; i++)
            {
                fibonacciNum = startNum + secondNum;
                Console.Write(fibonacciNum + ", ");
                startNum = secondNum;
                secondNum = fibonacciNum;
            }
        }
    }
}
