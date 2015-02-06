using System;
using System.Collections.Generic;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

class MinMaxSumAverage
{
    static void Main()
    {
        Console.WriteLine("Insert number of sequences n:");
        int countNum = int.Parse(Console.ReadLine());
        List<int> input = new List<int>(countNum);
        for (int i = 0; i < countNum; i++)
        {
            Console.Write("Enter the next whole number of sequence: ");
            int inputNum = int.Parse(Console.ReadLine());
            input.Add(inputNum);
        }

        int numMin = int.MaxValue;
        int numMax = int.MinValue;
        int sum = 0;
        foreach (var inputNum in input)
        {
            numMin = Math.Min(numMin, inputNum);
            numMax = Math.Max(numMax, inputNum);
            sum = sum + inputNum;
        }
        double averageNumbers = sum/countNum;
        Console.WriteLine("Max number: {0:}\nMin number: {1}\nSum: {2:F2}\nAvg: {3:F2}",
            numMax, numMin, sum, averageNumbers);
    }
}

