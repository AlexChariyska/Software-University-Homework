using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryToDecimalNumber
{
    static void Main(string[] args)
    {
        //Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string
        string input = Console.ReadLine();
        int n = input.Count();
        double sum = 0;
        for (int i =0; i<n; i++)
        {
            if (input[n-1-i] == '1')
            {
                sum = sum + Math.Pow(2, i);
            }
            
        }
        Console.WriteLine(sum);
    }
}

