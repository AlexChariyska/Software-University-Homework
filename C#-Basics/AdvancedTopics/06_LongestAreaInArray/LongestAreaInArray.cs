using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them

class LongestAreaInArray
{
    static void Main()
    {
        Console.WriteLine("Insert number of sequences:");
        int number = int.Parse(Console.ReadLine());
        string[] sequences = new string[number];
        for (int i = 0; i < sequences.Length; i++)
        {
            sequences[i] = Console.ReadLine();
        }

        int maxSequence = 0;
        string value = null;

        for (int i = 0; i < sequences.Length; i++)
        {

            int countSequence = 0;


            for (int j = i; j < sequences.Length; j++)
            {
                if (sequences[i] == sequences[j])
                {
                    countSequence++;


                    if (maxSequence < countSequence)
                    {
                        maxSequence = countSequence;
                        value = sequences[i];
                    }
                }
                else
                {
                    break;
                }
            }
        }

        Console.WriteLine("\nThe element of maximal sequence is \"{0}\", repeated {1} times", value, maxSequence);
    }
}
