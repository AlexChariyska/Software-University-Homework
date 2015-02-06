using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to find the longest word in a text

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        List<string> input = new List<string>(text.Split(new char[] { ' ' }));
        string result = input[0];
        foreach (var word in input)
        {
            if (word.Length > result.Length)
            {
                result = word;
            }

        }
        Console.WriteLine(result);

    }
}

