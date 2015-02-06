using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line. 

class RemoveNames
{
    static void Main()
    {
        string input = Console.ReadLine();
        List <string> names = new List<string> (input.Split(new char[] {' '}));
        string inputSecond = Console.ReadLine();
        List <string> equalsNames = new List<string> (inputSecond.Split(new char[] {' '}));
        for (int i = 0; i < equalsNames.Count; i++)
        {
            for (int j = 0; j < names.Count; j++)
            {
                if (equalsNames[i]==names[j])
                {
                    names.Remove(names[j]);
                }
            }
        }
        foreach (var name in names)
        {
            Console.Write(name + " ");
        }     
    }
}

