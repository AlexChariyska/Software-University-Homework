namespace Customer
{
    using System.Collections.Generic;
    public interface ICustomer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        int Id { get; set; }
        string PermanentAddress { get; set; }
        string MobilePhone { get; set; }
        string Email { get; set; }
        List<Payment> Payments { get; set; }
        CustomerType CustomerType { get; set; }
    }
}
