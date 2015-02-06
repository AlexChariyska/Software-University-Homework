using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 

class SumOfNumbers
{
    static void Main()
    {
        double sum = 0;
        Console.WriteLine("Enter a number n: ");
        double number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
		{
			int num = int.Parse(Console.ReadLine());
            sum = sum + num;
		}
        Console.WriteLine("The sum is: {0}.",sum);
    }
}

