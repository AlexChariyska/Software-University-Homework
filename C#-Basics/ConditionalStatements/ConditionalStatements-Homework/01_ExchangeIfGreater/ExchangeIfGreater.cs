using System;

//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. 

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Insert first number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert second number:");
        double secondNum = double.Parse(Console.ReadLine());
        double biggerNumber;
        if (firstNum > secondNum)
        {
            biggerNumber = firstNum;
            firstNum = secondNum;
            Console.WriteLine(biggerNumber + " " + firstNum);
        }
        else
        {
            if (firstNum == secondNum)
            {
                Console.WriteLine("Numbers are equal.");
            }
            else
            {
                biggerNumber = secondNum;
                Console.WriteLine("Result: " + biggerNumber + " " + firstNum);
            }
        }
    }
}

