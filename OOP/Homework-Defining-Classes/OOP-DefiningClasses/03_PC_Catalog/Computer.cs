using System;
using System.Collections.Generic;
using System.Linq;
class Computer
{
    private string name;
    private decimal price;
    private List<Component> components;

    public List<Component> Components
    {
        get { return components; }
        set {
            if (value==null)
            {
                throw new ArgumentException("Invalid input. Argument isComponents are mandatory");
            }
            this.components = value;
        }
    }
    
    public decimal Price
    {
       get 
       {
           return this.Components.Sum(a => a.Price);
       }
    }
    

    public string Name
    {
        get { return name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input. Name is mandatory");
            }
            this.name = value;
        }
    }

    //Constructor
    public Computer(string name, List<Component> components)
    {
        this.Name = name;
        this.Components = components;
    }

    public override string ToString()
    {
        string result = String.Format("*****Computer*****: \n Name:{0}\n Components List: \n", this.Name);
        foreach (Component component in Components)
        {
            result += component + "\n";
        }

        result += "Price Sum: " + this.Price + " BGN\n\n";
        return result;
    }
}

