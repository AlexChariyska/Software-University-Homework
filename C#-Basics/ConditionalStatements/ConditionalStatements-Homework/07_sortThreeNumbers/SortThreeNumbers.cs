using System;

//Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality. 

class SortThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert first number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert second number:");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert third number:");
        double thirdNum = double.Parse(Console.ReadLine());
        if (firstNum > secondNum && secondNum > thirdNum)
        {
            Console.WriteLine("The numbers are: {0}, {1}, {2}.", firstNum, secondNum, thirdNum);
        }
        else if (firstNum > thirdNum && thirdNum > secondNum)
        {
            Console.WriteLine("The numbers are: {0}, {1}, {2}.", firstNum, thirdNum, secondNum);
        }
        else if (secondNum > firstNum && firstNum > thirdNum)
        {
            Console.WriteLine("The numbers are: {0}, {1}, {2}.", secondNum, firstNum, thirdNum);
        }
        else if (secondNum > thirdNum && thirdNum > firstNum)
        {
            Console.WriteLine("The numbers are: {0}, {1}, {2}.", secondNum, thirdNum, firstNum);
        }
        else if (thirdNum > firstNum && firstNum > secondNum)
        {
            Console.WriteLine("The numbers are: {0}, {1}, {2}.", thirdNum, firstNum, secondNum);
        }
        else if (thirdNum > secondNum && secondNum > firstNum)
        {
            Console.WriteLine("The numbers are: {0}, {1}, {2}.", thirdNum, secondNum, firstNum);
        }
        else
        {
            Console.WriteLine("Numbers are equal.");
        }
    }
}

