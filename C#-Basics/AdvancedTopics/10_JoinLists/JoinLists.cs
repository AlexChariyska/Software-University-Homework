using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line. 


class JoinLists
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> firstList = new List<string>(input.Split(new char[] { ' ' }));
        string input2 = Console.ReadLine();
        List<string> secondList = new List<string>(input2.Split(new char[] { ' ' }));
      

        List<int> resultList = new List<int>();
        List<int> joinList = new List<int>();

        for (int i = 0; i < firstList.Count; i++)
        {
            joinList.Add(int.Parse(firstList[i]));
        }
        for (int i = 0; i <secondList.Count; i++)
        {
            joinList.Add(int.Parse(secondList[i]));
        }

        joinList.Sort();
        resultList = joinList.Distinct().ToList();

        firstList.Sort();
        foreach (var result in resultList)
        {
            Console.Write(result + " ");
        }
    }
}

