using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomNumber = random.Next(min,(max+1));
            Console.Write(randomNumber + " ");
        }
    }
}

