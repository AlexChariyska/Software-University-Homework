using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PrintCompanyInformation
{
    class PrintCompanyInfo
    {
        static void Main()
        {
            //Problem.02 A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.

            Console.WriteLine("Insert company name:");
            string company = Console.ReadLine();
            Console.WriteLine("Insert company address:");
            string address = Console.ReadLine();
            Console.WriteLine("Insert company phone number:");
            int numberCompany = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert company fax number:");
            int faxCompany = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert company web site:");
            string webSite = Console.ReadLine();
            Console.WriteLine("Insert company manager's first name:");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Insert company manager's last name:");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Insert company manager's age:");
            int ageManager = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert company manager's phone number:");
            int numberManager = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}\nAddress: {1}.\nPhone number: {1}.\nFax: {2}.\nWeb site: {3}.",
                company,address, numberCompany, faxCompany, webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, phone number: {3})", managerFirstName, managerLastName, ageManager, numberManager);
        }
    }
}
