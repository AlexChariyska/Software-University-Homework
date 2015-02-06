using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Insert number \"a\":");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Insert number \"b\":");
        float b = float.Parse(Console.ReadLine());
        if (a == b)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

