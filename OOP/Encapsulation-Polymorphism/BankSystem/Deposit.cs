namespace BankSystem
{
    using System;
    public class Deposit : Accounds
    {
        public Deposit(CustomerType customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate){}

        public override decimal CalculateInterest(byte months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                this.InterestRate = 0;
            }

            return this.Balance * (1 + (decimal)this.InterestRate * (decimal)(months));

        }

        public void Withdraw(decimal money)
        {
            this.Balance -= money;
        }
    }
}
