using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a number n and a sequence of n integers, sorts them and prints them. 

class SortingNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert number of sequences:");
        int number = int.Parse(Console.ReadLine());
        List<int> sequences = new List<int>();
        for (int i = 0; i < number; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sequences.Add(num);
        }
        Console.WriteLine();
        sequences.Sort();
        foreach (var integer in sequences)
        {
            Console.WriteLine(integer);
        }
    }
}

