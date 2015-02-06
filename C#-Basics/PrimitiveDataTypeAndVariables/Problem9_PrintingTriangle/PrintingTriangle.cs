using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9_PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char symbol = '\u00A9';
            Console.WriteLine("  {0}  ", symbol);
            Console.WriteLine(" {0}{0}{0} ", symbol);
            Console.WriteLine("{0}{0}{0}{0}{0}", symbol);
        }
    }
}
