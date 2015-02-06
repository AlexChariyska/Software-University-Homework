namespace BankSystem
{
    using System;

    public class BankSystem
    {
        static void Main()
        {
            IAccounts individual2 = new Loan(CustomerType.Individual, 4500, 3);
            IAccounts individual1 = new Deposit(CustomerType.Individual, 4500, 3.5);

            Console.WriteLine(individual1.ToString());
            decimal result = individual1.CalculateInterest(6);
            Console.WriteLine("Individual-Deposit Calculate Interest Rate for 6 months: {0}", individual1.CalculateInterest(5));
            Console.WriteLine("Individual-Loan Calculate Interest Rate for 6 months: {0}", individual2.CalculateInterest(5));
            Console.WriteLine();

            Console.WriteLine("After depositing");
            individual1.DepositMoney(5678);
            Console.WriteLine(individual1.ToString());
            Console.WriteLine();

            Console.WriteLine("Withdrawing");
            Deposit indiv3 = new Deposit(CustomerType.Individual, 4500, 3.5);
            Console.WriteLine(indiv3.ToString());
            indiv3.Withdraw(6666);
            Console.WriteLine(indiv3.ToString());
        }
    }
}
