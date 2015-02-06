using System;

//Write a program that finds the biggest of three numbers

class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert first number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert second number:");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert third number:");
        double thirdNum = double.Parse(Console.ReadLine());
        double result = Math.Max(Math.Max(firstNum,secondNum), thirdNum);
        Console.WriteLine("The biggest number is: {0}",result);
    }
}

