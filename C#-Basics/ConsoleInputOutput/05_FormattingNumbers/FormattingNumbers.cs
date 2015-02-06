using System;

//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned

class FormattingNumbers
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());
        float num3 = float.Parse(Console.ReadLine());
        string binary = Convert.ToString(num1, 2);
        if (num1 <= 500 & num1 >= 0)
        {
            Console.WriteLine("{0,-10:X}|{1}|{2,10:F2}|{3,-10:0.000}|", num1, binary.PadLeft(10, '0'), num2, num3);
        }
        else
        {
            Console.WriteLine("Number a is not between 0 ≤ a ≤ 500.");
        }
    }
}

