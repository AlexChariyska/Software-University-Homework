using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 

class OddEvenProduct
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] input = str.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        int sumOdd = 1;
        int sumEven = 1;
        for (int i = 0; i < input.Length; i++)
        {
            // Because we start counting the first element as 1, our even numbers are actually odd.
            if (i % 2 == 0)
            {
                int num = Convert.ToInt16(input[i]);
                sumOdd = sumOdd * num;
            }
            else
            {
                int num = Convert.ToInt16(input[i]);
                sumEven = sumEven * num;
            }
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", sumOdd);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("0dd_product = {0}", sumOdd);
            Console.WriteLine("Even_product = {0}", sumEven);
        }
    }
}

