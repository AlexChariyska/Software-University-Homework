using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters should be listed in alphabetical order. 

class countOfLetters
{
    static void Main()
    {
        string str = Console.ReadLine();
        List<string> input = new List<string>(str.Split(new char[] { ' ' }));
        input.Sort();
        List<int> nValue = new List<int>();
        List<int> counter = new List<int>();
        int count = 0;

        for (int n = 0; n < input.Count; n++)
        {

            if (n == 0)
            {
                count++;
                if (input[n] != input[n + 1])
                {
                    nValue.Add(n);
                    counter.Add(count);
                }
            }

            else if (input[n] == input[n - 1])
            {
                count++;
                if (n == input.Count - 1 || (input[n] != input[n + 1]))
                {
                    nValue.Add(n);
                    counter.Add(count);

                }
            }
            else
            {
                count = 1;

                if (n == input.Count - 1 || (input[n] != input[n + 1]))
                {
                    nValue.Add(n);
                    counter.Add(count);
                }

            }
        }
        for (int i = 0; i < nValue.Count; i++)
        {
            Console.WriteLine(input[nValue[i]] + "--> " + counter[i]);
        }
    }
}