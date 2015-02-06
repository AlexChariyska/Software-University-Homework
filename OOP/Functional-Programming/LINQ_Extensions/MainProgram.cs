namespace LINQ_Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            List<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            var allStr = strList.Repeat(3);
            foreach (var item in allStr)
            {
                Console.WriteLine(item);
            }

            var WhereNotStr = strList.WhereNot(x => x == "one");
            Console.WriteLine();
            foreach (var item in WhereNotStr)
            {
                Console.WriteLine(item);
            }

            var WhereEndsWithStr = strList.WhereEndsWith(new List<string>() { "e" });
            Console.WriteLine();
            foreach (var item in WhereEndsWithStr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
