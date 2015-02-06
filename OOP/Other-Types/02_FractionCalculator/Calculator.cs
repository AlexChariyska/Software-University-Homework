namespace FractionCalculator
{
    using System;
    class Calculator
    {
        static void Main()
        {
            Fraction f1 = new Fraction(22, 7);
            Fraction f2 = new Fraction(40, 4);
            Fraction result = f1 + f2;
            Console.WriteLine("Adding: f1 + f2");
            Console.WriteLine(result);
            Console.WriteLine("Result denominator:");
            Console.WriteLine(result.Denominator);
        }
    }
}
