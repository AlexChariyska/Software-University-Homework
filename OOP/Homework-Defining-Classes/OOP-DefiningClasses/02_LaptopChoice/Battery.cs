using System;

class Battery
{
    private string description;
    private double lifeInHours;

    public Battery(string description, double lifeInHours)
    {
        this.description = description;
        this.lifeInHours = lifeInHours;
    }
    public string Description
    {
        get
        {
            return this.description;
        }
        set
        {
            if (value != null && value.Length < 1)
            {
                throw new ArgumentNullException("Description can not be null");
            }
            this.description = value;
        }
    }

    public double LifeInHours
    {
        get
        {
            return this.lifeInHours;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(" Battery Life cannot be negative");
            }
            this.lifeInHours = value;
        }
    }
    public override string ToString()
    {
        string result = "";
        if (this.Description != null)
        {
            result = String.Format(
            "\n[Battery description: {0}, Battery life: {1} hours ]", this.Description, this.LifeInHours);
        }
        else
        {
            result = "[ " + this.LifeInHours + " hours ]";
        }
        return result;
    }
}

