using System;
using System.Collections.Generic;
using System.Linq;
class Component
{
    private string name;
    private decimal price;
    private string details;

    public decimal Price { 
        get
        {
            return this.price;
        }
        set
        {
            if(value<0)
            {
                throw new ArgumentException("Invalid input. Argument must be positive");
            }
            this.price = value;
        }
    }
    public string Name {
        get
        {
            return this.name;
        }
        set 
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input. Argument is mandatory");
            }
            this.name = value;
        }
    }
    public string Details {
        get 
        {
            return this.details;
        } 
        set 
        {
            this.details = value;
        }
    }
    //Constructors
    public Component(string name, string details, decimal price)
    {
        this.Name = name;
        this.Price= price;
        this.Details = details;
    }
    public Component(string name, decimal price)
            : this(name, null,price) { }

    public override string ToString()
    {
        string result = String.Format("   Component: (Component Name: {0}, ", this.Name);
        if (this.Details != null)
        {
            result += "Details: " + this.Details + ", ";
        }

        result += " Price: " + this.Price + ")";
        return result;
    }
}

