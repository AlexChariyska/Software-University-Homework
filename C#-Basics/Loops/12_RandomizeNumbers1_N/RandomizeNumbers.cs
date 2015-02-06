using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 

class RandomizeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] input = new int[n];
        int[] indexRandom = new int[n];
        Random random = new Random();
        for (int i = 1; i <= n; i++)
        {
            input[i-1] = i;
        }
        
        for (int i = 0; i < n; i++)
        {
        int index = random.Next(1,n+1);
        if (indexRandom.All(element => element != index))
        {
            indexRandom[i] = index;
        }
        else
        {
            i--;
        }
        }
        foreach (var num in indexRandom)
        {
            Console.Write(num + " ");
        }
       
    }
}

