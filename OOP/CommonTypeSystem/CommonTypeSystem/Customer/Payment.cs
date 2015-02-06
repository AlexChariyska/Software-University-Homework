namespace Customer
{
    using System;

    public class Payment
    {
        private string productName;
        private double price;

        public Payment(string productName, double price)
        {
            this.Price = price;
            this.ProductName = productName;
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                this.productName = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Product name:{0}, Price:{1}", this.ProductName, this.Price);
        }
    }
}
