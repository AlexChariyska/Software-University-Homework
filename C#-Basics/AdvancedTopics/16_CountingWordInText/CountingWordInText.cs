using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that counts how many times a given word occurs in given text. The first line in the input holds the word. The second line of the input holds the text. The output should be a single integer number – the number of word occurrences. Matching should be case-insensitive. Note that not all matching substrings are words and should be counted. A word is a sequence of letters separated by punctuation or start / end of text. 

    class CountingWordInText
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            List<string> input = new List<string>(text.Split(new char[] { ' ', '.', ',', '"', '@', '!', '?', '/', '\\', ':', ';', '(', ')' }, StringSplitOptions.None));
            int count = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (string.Equals(input[i], word, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

