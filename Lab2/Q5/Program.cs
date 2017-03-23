using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            string word;
            int numberOfVowels = 0;

            //Input
            Console.Write("Enter a word: ");
            word = Console.ReadLine();

            //Processing
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i].ToString().ToUpper())
                {
                    case "A":
                    case "E":
                    case "I":
                    case "O":
                    case "U":
                        numberOfVowels++;
                        break;
                    default:
                        break;
                }
            }

            //Output
            Console.WriteLine("The word {0} has {1} vowels.", word, numberOfVowels);
        }
    }
}
