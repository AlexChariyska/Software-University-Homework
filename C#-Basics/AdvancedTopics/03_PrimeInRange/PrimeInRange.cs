using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeInRange
{
    static void Main()
    {
        Console.WriteLine("Insert first number: ");
        int startNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert the end of the range: ");
        int endNum = int.Parse(Console.ReadLine());
        FindPrimesInRange(startNum, endNum);

    }
    static void FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
                bool result = true;
                if (i == 0 || i == 1 || i == 2)
                {
                    result = false;
                }
                else
                {
                    for (int a = 2; a <= Math.Sqrt(i); a++)
                    {
                        if (i % a == 0)
                        {
                            result = false;
                        }
                    }
                }
                if (result == true)
                {
                    primes.Add(i);
                }
        }
            foreach (var number in primes)
            {
                Console.Write(number + " ");
            }
        }
    }

