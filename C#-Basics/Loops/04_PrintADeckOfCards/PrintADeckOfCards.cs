using System;

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades.

class PrintADeckOfCards
{
    static void Main()
    {
        string[] deck = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        char[] symbols = new char[4] { '\u0003', '\u0004', '\u0005', '\u0006' };
        foreach (var card in deck)
        {
            foreach (var symbol in symbols)
            {
                Console.Write(card + symbol + " ");
            }
            Console.WriteLine();
        }
    }
}

