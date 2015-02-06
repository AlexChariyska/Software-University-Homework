using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class HexedecimalToBinary
    {
        static void Main()
        {
            //Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. 


            string hexNumber = Console.ReadLine();
            double sum=0;
            int indexer = hexNumber.Length-1;
            for (int i = 0; i < hexNumber.Length; i++)
            {
                int symbolInHex;
                switch (hexNumber[i])
            {          
                case 'A':
                    symbolInHex = 10;
                    break;
                case 'B':
                    symbolInHex = 11;
                    break;
                case 'C':
                    symbolInHex = 12;
                    break;
                case 'D':
                    symbolInHex = 13;
                    break;
                case 'E':
                    symbolInHex = 14;
                    break;
                case 'F':
                    symbolInHex = 15;
                    break;
                default:
                    symbolInHex = int.Parse(hexNumber[i].ToString());
                    break;
            }

                sum = sum + symbolInHex * Math.Pow(16, indexer);
                indexer--;
            }
            Console.WriteLine(sum);
        }
    }

