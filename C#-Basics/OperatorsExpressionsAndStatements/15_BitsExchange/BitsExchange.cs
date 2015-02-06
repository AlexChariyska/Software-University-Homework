using System;


class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Insert a number:");
        int input = int.Parse(Console.ReadLine());
        int mask3 = 7 << 3;
        int mask24 = 7 << 24;
        int bitExchange3 = input & mask3;
        int bitExchange24 = input & mask24;
        // making zero
        input = input & (~mask3);
        input = input & (~mask24);
        input = input | (bitExchange3 << 21);
        input = input | (bitExchange24 >>21);
        Console.WriteLine(input);
    }
}

