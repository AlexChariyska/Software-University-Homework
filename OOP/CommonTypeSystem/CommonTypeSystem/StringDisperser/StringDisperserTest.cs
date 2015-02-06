
namespace StringDisperser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StringDisperserTest
    {
        static void Main()
        {
            StringDisperser anna = new StringDisperser("Anna", "Ivanova", "Georgieva");
            StringDisperser pesho = new StringDisperser("Pesho", "Peshev", "Petrov");
            Console.WriteLine("Equal: {0}", Equals(anna, pesho));
            Console.WriteLine(anna);
            Console.WriteLine(pesho);
            Console.WriteLine();

            StringDisperser ginko = new StringDisperser("Ginko", "Biloba");
            StringDisperser[] stringDispersers = { ginko, anna };
            Array.Sort(stringDispersers);
            Console.WriteLine("Sort by total string lexicographically");
            foreach (var stringDisperser in stringDispersers)
            {
                Console.WriteLine(stringDisperser);
            }

            foreach (var ch in ginko)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            StringDisperser ginkoNew = (StringDisperser)ginko.Clone();
            ginkoNew.Words = new string[2] { "Ginko", "Ginko" };
            Console.WriteLine("Clone:");
            Console.WriteLine("original: {0}", ginko);
            Console.WriteLine("cloning: {0}", ginkoNew);

        }
    }
}
