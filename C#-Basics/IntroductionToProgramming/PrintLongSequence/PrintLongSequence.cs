using System;

class PrintLongSequence
{
    static void Main()
    {
        int a = 0;
        int b = -1;
        int count = 0;
        do
        {
            a = a + 2;
            b = b - 2;
            count = count + 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        while (count < 500);
    }
}
