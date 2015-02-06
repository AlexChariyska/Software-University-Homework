namespace BankSystem
{
    using System;

    class Loan : Accounds
    {
        public Loan(CustomerType customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {}

        public override decimal CalculateInterest(byte months)
        {
            if (this.Customer == CustomerType.Individual)
            {
                return this.Balance * (1 + (decimal)this.InterestRate * (decimal)(months - 3));
            }
            else
            {
                return this.Balance * (1 + (decimal)this.InterestRate * (decimal)(months - 2));
            }
        }
    }
}
