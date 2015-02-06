using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Squar
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine(Math.Sqrt(num));
            return;
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number - must be positive!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }

    }
}

