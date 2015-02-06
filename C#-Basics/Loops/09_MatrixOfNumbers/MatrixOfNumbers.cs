using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. 


class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert number n:");
        int num = int.Parse(Console.ReadLine());
        if ((1 <= num) && (num <= 20))
        {
            for (int row = 1; row <= num; row++)
            {
                Console.Write(row);
                for (int i = (row + 1); i <= (row + (num - 1)); i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}

