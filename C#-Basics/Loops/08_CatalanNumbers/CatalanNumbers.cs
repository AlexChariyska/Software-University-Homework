using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert number n: ");
        int numN = int.Parse(Console.ReadLine());
        if ((1 < numN) && (numN < 100))
        {
            int num2N = numN * 2;
            BigInteger factorial2N = 1;
            BigInteger factorialNPlus = 1;
            BigInteger factorialN = 1;
            
            for (int i = 1; i <= num2N; i++)
            {
                factorial2N = factorial2N * i;
            }
            for (int i = 1; i <= (numN+1); i++)
            {
                factorialNPlus = factorialNPlus * i;
            }
            for (int i = 1; i <= numN; i++)
            {
                factorialN = factorialN * i;
            }
            BigInteger formula = factorial2N / (factorialNPlus * factorialN);
            Console.WriteLine("Catalan n number: " + formula);
        }
        else
        {
            Console.WriteLine("Invalid number !");
        }
    }
}

