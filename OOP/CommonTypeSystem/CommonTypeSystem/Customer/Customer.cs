namespace Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer : ICustomer, IComparable<Customer>, ICloneable
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private int id;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private List<Payment> payments;
        private CustomerType customerType;

        public Customer(string firstName,
                         string lastName,
                         string middleName,
                         int id,
                         string permanentAddress,
                         string mobilePhone,
                         string email,
                         List<Payment> payments,
                         CustomerType customerType)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.Id = id;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = payments;
            this.CustomerType = customerType;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Id { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public List<Payment> Payments { get; set; }
        public CustomerType CustomerType { get; set; }

        public override string ToString()
        {
            string payment = String.Join(", ", this.Payments);
            return string.Format("Customer:{0} {1} {2},\nInformation:{3}, {4}, {5}, {6}\nPayments: {7}",
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Id,
                this.PermanentAddress,
                this.MobilePhone,
                this.Email,
                payment,
                this.CustomerType);
        }
        public override bool Equals(object param)
        {
            Customer customer = param as Customer;

            // Check if we have valid not null Student object
            if (customer == null)
            {
                return false;
            }

            // Compare the  Id which must be diffrent for each person
            if (!Object.Equals(this.Id, customer.Id))
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }

        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !(Customer.Equals(customer1, customer2));
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ Id.GetHashCode();
        }

        public int CompareTo(Customer otherCustomer)
        {
            if (this.FirstName != otherCustomer.FirstName || this.MiddleName != otherCustomer.MiddleName || this.LastName != otherCustomer.LastName)
            {
                return -1;
            }
            if (this.Id != otherCustomer.Id)
            {
                return (otherCustomer.Id - this.Id);
            }
            return 0;
        }

        object ICloneable.Clone()  // Implicit interface implementation
        {
            return this.Clone();
        }
        public Customer Clone() // Deep cloning (public method)
        {
            Customer result = new Customer(FirstName = this.FirstName,
                                           MiddleName = this.MiddleName,
                                           LastName = this.LastName,
                                           Id = this.Id,
                                           PermanentAddress = this.PermanentAddress,
                                           MobilePhone = this.MobilePhone,
                                           Email = this.Email,
                                           Payments = this.Payments,
                                           CustomerType = this.CustomerType);

            return result;
        }
    }
}
