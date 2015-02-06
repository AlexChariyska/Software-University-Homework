using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12_BankData
{
    class BankData
    {
        static void Main()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your middle name:");
            string middleName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your bank name:");
            string bank = Console.ReadLine();
            Console.WriteLine("Enter your available amount of money:");
            int balance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your IBAN:");
            string iban = Console.ReadLine();
            Console.WriteLine("Enter your credit card numbers:");
            string creditCard = Console.ReadLine();
            string creditCard2 = Console.ReadLine();
            string creditCard3 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Holder's names: {0} {1} {2}.",
                firstName, middleName, lastName);
            Console.WriteLine("\nBank: {0}\nBalance: {1}\nIBAN: {2}.",
                bank, balance, iban);
            Console.WriteLine("Credit cards numbers:\n{0}\n{1}\n{2}",
                creditCard, creditCard2, creditCard3);
        }
    }
}
