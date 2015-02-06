using System;

// Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

class NumbersDividedByANumber
{
    static void Main()
    {
    Console.WriteLine("Insert start number:");
    int numStart = int.Parse(Console.ReadLine());
    Console.WriteLine("Insert end number:");
    int numEnd = int.Parse(Console.ReadLine());
    int sum = 0;
    for (int i = numStart; i <= numEnd; i++)
    {
        int divider = i % 5;
        if (divider == 0)
        {
            sum = sum + 1;
        }
    }
    Console.WriteLine(sum);
    }
}

