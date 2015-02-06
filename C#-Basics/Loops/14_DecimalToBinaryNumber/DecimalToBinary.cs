using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. 


class DecimalToBinary
{
    static void Main()
    {
      
            long decimalNumber = long.Parse(Console.ReadLine());
            string binNumber = "";
            while (decimalNumber != 0)
            {
                int remainder = (int) decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                binNumber = remainder + binNumber;
            }
            Console.WriteLine(binNumber);
        

    }
}
