namespace BankSystem
{
    using System;

    public interface IAccounts
    {
        CustomerType Customer { get; set; }
        decimal Balance { get; set; }
        double InterestRate { get; set; }
        decimal CalculateInterest(byte months);

        void DepositMoney(decimal money);

    }
}
