using System;

//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. 

class SequenceOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert n:");
        int num = int.Parse(Console.ReadLine());            // I put an empty line because it 
        Console.WriteLine("");                              //looks better when printed.
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}

