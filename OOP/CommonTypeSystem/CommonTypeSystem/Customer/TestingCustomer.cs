namespace Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestingCustomer
    {
        static void Main()
        {
            List<Payment> paymentList1 = new List<Payment>(){
                new Payment("Laptop", 3000),
                new Payment("Iphone", 2000)};
    
            List<Payment> paymentList2 = new List<Payment>() { 
               new Payment("Tablet", 500),
               new Payment("Iphone", 2000),
               new Payment("TV", 4000)
            };


            Customer customer1 = new Customer("Petko", "Peshov", "Petkov", 123456789, "Sofia ul.60", "+359 88 123 4523", "pesho@abv.bg", paymentList1, CustomerType.Regular);
            Customer customer2 = new Customer("Anna", "Mileva", "Ivanova", 123123123, "Botevgrad ul.10", "+359 88 000 2222", "anna@abv.bg", paymentList2, CustomerType.Golden);
            Customer customer3 = new Customer("Anna", "Mileva", "Ivanova", 123123123, "Varna ul.10", "+359 88 000 2222", "anna@abv.bg", paymentList2, CustomerType.Diamond);
            Console.WriteLine(customer1.ToString());
            Console.WriteLine("Is equal: ");
            if (Equals(customer3,customer2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine("Clone ");
            Customer cloned = customer1.Clone();
            cloned.FirstName = "Kiro";
            cloned.LastName = "Kirov";
            cloned.Id = 36589758;
            Console.WriteLine(cloned.ToString());
            Console.WriteLine(customer1.ToString());
        }
    }
}
