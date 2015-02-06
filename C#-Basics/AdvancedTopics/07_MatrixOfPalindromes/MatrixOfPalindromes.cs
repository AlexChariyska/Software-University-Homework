using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class MatrixOfPalindromes
{
    static void Main(string[] args)
    {
        //Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
            Console.WriteLine("Insert rows:");
            int height= int.Parse(Console.ReadLine());
            Console.WriteLine("Insert columnss:");
            int width = int.Parse(Console.ReadLine());
            string[,] matrix = new string[height, width];
            for (int row = 0; row < height; row++)
                {
                    for (int col = 0; col < width; col++)
                    {
                        matrix[row, col] =
                            "" + (char)('a' + row) + (char)('a' + col);
                    }
                }

                for (int row = 0; row < height; row++)
                {
                    for (int col = 0; col < width; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }
    }
}
