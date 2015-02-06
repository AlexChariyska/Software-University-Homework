using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts and prints all URLs from given text. 

class ExtractURLfromText
{
    static void Main()
    {
        string text = Console.ReadLine();
        List<string> input = new List<string>(text.Split(new char[] { ' ' }));
        for (int i = 0; i < input.Count; i++)
        {
           string check = input[i].Substring(0,4);
            if (check == "http" || (check == "www."))
            {
                Console.WriteLine(input[i]);
            }
        }
       
    }
}

