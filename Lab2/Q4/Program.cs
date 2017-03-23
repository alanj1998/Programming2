using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string cardNotation, fullDescription = "";

            //Input
            Console.Write("Enter the card notation: ");
            cardNotation = Console.ReadLine();

            //Process
            switch (cardNotation[0].ToString().ToUpper())
            {
                case "1":
                    if (cardNotation[1] == '0')
                    {
                        if (cardNotation[2] == 'D')
                            fullDescription = "Ten of Diamonds";
                        else if (cardNotation[2] == 'H')
                            fullDescription = "Ten of Hearts";
                        else if (cardNotation[2] == 'S')
                            fullDescription = "Ten of Spades";
                        else if (cardNotation[2] == 'C')
                            fullDescription = "Ten of Clubs";
                        else
                            fullDescription = "Wrong Value entered!";
                    }
                    else
                        fullDescription =  "Invalid card!";
                    break;
                case "2":
                    fullDescription = "Two of ";
                    break;
                case "3":
                    fullDescription = "Three of ";
                    break;
                case "4":
                    fullDescription = "Four of ";
                    break;
                case "5":
                    fullDescription = "Five of ";
                    break;
                case "6":
                    fullDescription = "Six of ";
                    break;
                case "7":
                    fullDescription = "Seven of ";
                    break;
                case "8":
                    fullDescription = "Eight of ";
                    break;
                case "9":
                    fullDescription = "Nine of ";
                    break;
                case "J":
                    fullDescription = "Jack of ";
                    break;
                case "Q":
                    fullDescription = "Queen of ";
                    break;
                case "K":
                    fullDescription = "King of ";
                    break;
                case "A":
                    fullDescription = "Ace of ";
                    break;
                default:
                    Console.WriteLine("Wrong value entered!");
                    break;
            }

            switch (cardNotation[1].ToString().ToUpper())
            {
                case "0":
                    break;
                case "S":
                    fullDescription += "Spades";
                    break;
                case "D":
                    fullDescription += "Diamonds";
                    break;
                case "C":
                    fullDescription += "Clubs";
                    break;
                case "H":
                    fullDescription += "Hearts";
                    break;
                default:
                    fullDescription += "";
                    break;
            }

            //Output
            Console.WriteLine(fullDescription);
        }
    }
}
