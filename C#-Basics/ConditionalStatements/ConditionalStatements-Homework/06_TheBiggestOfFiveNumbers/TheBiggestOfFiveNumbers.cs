using System;

//Write a program that finds the biggest of five numbers by using only five if statements. 

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert first number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert second number:");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert third number:");
        double thirdNum = double.Parse(Console.ReadLine()); 
        Console.WriteLine("Insert  forth number:");
        double forthNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert  fifth number:");
        double fiftNum = double.Parse(Console.ReadLine());
    if (firstNum > secondNum && firstNum > thirdNum && firstNum > forthNum && firstNum > fiftNum)
        {
            Console.WriteLine(firstNum);
        }
        else if (secondNum > firstNum && secondNum > thirdNum && secondNum > forthNum && secondNum > fiftNum)
        {
            Console.WriteLine(secondNum);
        }
        else if (thirdNum > firstNum && thirdNum > secondNum && thirdNum > forthNum && thirdNum > fiftNum)
        {
            Console.WriteLine(thirdNum);
        }
        else if (forthNum > firstNum && forthNum > secondNum && forthNum > thirdNum && forthNum > fiftNum)
        {
            Console.WriteLine(forthNum);
        }
        else
        {
            Console.WriteLine(fiftNum);
        }
    }
}

