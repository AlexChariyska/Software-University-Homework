namespace BankSystem
{
    using System;

    class Mortgages : Accounds
    {
        const byte PrivilegeIndiv = 6;
        const byte PrivilegeComp = 12;

        public Mortgages(CustomerType customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        { }

        public override decimal CalculateInterest(byte months)
        {
            if (this.Customer == CustomerType.Individual)
            {
                return this.Balance * (1 + (decimal)this.InterestRate * (months - PrivilegeIndiv));
            }
            else
            {
                return this.Balance * (1 + (decimal)this.InterestRate * (decimal)(months - PrivilegeComp) + ((decimal)this.InterestRate / 2) * 12);
            }
        }
    }
}
