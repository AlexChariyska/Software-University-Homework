using System;

namespace Problem_8_QuotesInStrings
{
    class Quotes
    {
        static void Main()
        {
            string a = "The \"use\" of quotations causes difficulties.";
            string b = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
