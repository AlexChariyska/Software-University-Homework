using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14_ASCII_Table
{
    class ASCII
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
