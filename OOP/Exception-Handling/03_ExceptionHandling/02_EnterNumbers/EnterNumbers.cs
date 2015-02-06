using System;


////Write a method ReadNumber(int start, int end) that 
//enters an integer number in given range [start…end]. If an invalid 
//number or non-number text is entered, the method should throw an 
//exception. Using this method write a program that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100.
//If the user enters an invalid number, let the user to enter again.

class EnterNumbers
{

    static void Main()
    {
        Console.WriteLine("Enter start number:");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end number:");
        int end = int.Parse(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            start = ReadNumber(start, end);
        }
    }
    static int ReadNumber(int start, int end)
    {
        int num = 0;
        try
        {
            Console.Write("Enter your number: ");
            num = int.Parse(Console.ReadLine());
            if (!(start < num && num < end))
            {
                while (!(start < num && num < end))
                {
                    Console.WriteLine("Your number is not in range {0} - {1} !", start, end);
                    Console.Write("Enter your number: ");
                    num = int.Parse(Console.ReadLine());
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Number format! Please enter an integer");
        }
        return num;
    }
}


