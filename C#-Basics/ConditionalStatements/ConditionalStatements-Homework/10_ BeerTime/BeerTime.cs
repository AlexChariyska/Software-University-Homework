using System;
using System.Globalization;


//A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. 

class BeerTime
{
    static void Main()
    {
        try
        {
            string format = "h:mm tt";
            Console.WriteLine("Enter a time:");
            DateTime input = DateTime.ParseExact(Console.ReadLine(), format, null);
            DateTime beerhoursPM = DateTime.ParseExact("01:00 PM", format, null);
            DateTime beerhoursAM = DateTime.ParseExact("03:00 AM", format, null);
            if (input >= beerhoursPM)
            {
                Console.WriteLine("Beer time");
            }
            else if (input <= beerhoursAM)
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("Non-beer time");
            }
        }
        catch 
        {

            Console.WriteLine("Invalid time");
        }
        
    }
}