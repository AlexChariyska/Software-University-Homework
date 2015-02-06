using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. The output should be a variable of type string. 

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long decimalNum = long.Parse(Console.ReadLine());
        long? remainder = null;
        string hexNum = null;

        while (decimalNum > 0)
        {
            remainder = decimalNum % 16;
            switch (remainder)
            {
                case 10:
                    hexNum = 'A' + hexNum;
                    break;
                case 11:
                    hexNum = 'B' + hexNum;
                    break;
                case 12:
                    hexNum = 'C' + hexNum;
                    break;
                case 13:
                    hexNum = 'D' + hexNum;
                    break;
                case 14:
                    hexNum = 'E' + hexNum;
                    break;
                case 15:
                    hexNum = 'F' + hexNum;
                    break;
                default:
                    hexNum = remainder.ToString() + hexNum;
                    break;
            }
            decimalNum = decimalNum/16;
        }
        Console.WriteLine(hexNum);
    }
}

