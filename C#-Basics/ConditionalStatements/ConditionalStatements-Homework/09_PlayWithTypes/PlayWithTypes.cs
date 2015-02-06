using System;

//Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement

class PlayWithTypes
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: [1-2-3]");
        int type = int.Parse(Console.ReadLine());
        switch (type)
        {
            case 1: Console.WriteLine("Please enter an integer:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}", number+1);
                break;
            case 2: Console.WriteLine("Please enter a double:");
                double numberDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("{0}",numberDouble + 1);
                break;
            case 3: Console.WriteLine("Please enter a string:");
                string word = Console.ReadLine();
                Console.WriteLine(word+"*");
                break;
            default: Console.WriteLine("Invalid choice!");
                break;
        }
    }

}