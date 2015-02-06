namespace BankSystem
{
    using System;
    public abstract class Accounds : IAccounts
    {
        private CustomerType customer;
        private decimal balance;
        private double interestRate;

        public Accounds(CustomerType customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public CustomerType Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate can not be negative!");
                }

                this.interestRate = value;
            }
        }

        public virtual void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public abstract decimal CalculateInterest(byte months);

        public override string ToString()
        {
            return string.Format("Customer type: {1}\nBalance:{0}", this.Balance, this.Customer);
        }
    }
}
