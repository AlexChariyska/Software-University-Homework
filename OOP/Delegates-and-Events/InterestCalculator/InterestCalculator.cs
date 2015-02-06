using System;


namespace InterestCalculator
{

    // Declaration of a delegate
    public delegate void SimpleDelegate(double sum, double interest, double years);

    public class InterestCalculator
    {
        private const int n = 12;

        static void GetSimpleInterest(double sum, double interest, double years)
        {
            double result = sum * (double)(1 + (interest * years / 100));
            Console.WriteLine("Simple Interest");
            Console.WriteLine("{0:0.0000}", result, 4);
        }
        static void GetCompoundInterest(double sum, double interest, double years)
        {
            double result = sum * (double)Math.Pow(1 + (interest / 12 / 100), years * 12);
            Console.WriteLine("Compound Interest");
            Console.WriteLine("{0:0.0000}", result, 4);
        }

        static void Main()
        {
            // Instantiate the delegate
            SimpleDelegate delegateCompound = new SimpleDelegate(GetCompoundInterest);
            // Instantiate the delegate
            SimpleDelegate delegateSimple = new SimpleDelegate(GetSimpleInterest);

            // Invocation of the method, pointed by delegate
            delegateCompound(500, 5.6, 10);
            delegateSimple(2500, 7.2, 15);
        }
    }
}


