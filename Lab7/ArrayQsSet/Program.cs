using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQsSet
{
    class Program
    {
        static int[] playerAges = new int[6];

        static void Main(string[] args)
        {
            ValueRead();
            Print1st3rdAnd5th();
            PrintAllElements();
            Reverse();
            Avergae();
            bool meh = Search(1);
            Console.WriteLine(meh);

            ReverseOrder();

            int add = ArrayMultiplication();
            Console.WriteLine(add);
        }

        /*
         *  Q2 Method to read in six values from Console
         */
        static void ValueRead()
        {
            for (int i = 0; i < playerAges.Length; i++)
            {
                //Vars
                bool check = false;

                while (!check)
                {
                    Console.Write("Enter value {0}: ", i + 1);
                    check = int.TryParse(Console.ReadLine(), out playerAges[i]);
                    if (!check)
                        Console.WriteLine("Enter right value!");
                }
            }
        }

        /*
         *  Q3 Print 1st, 3rd and 5th
         */
        static void Print1st3rdAnd5th()
        {
            for(int i = 0; i < playerAges.Length; i+= 1)
                Console.WriteLine(playerAges[i]);
        }

        /*
         *  Q4 Foreach Loop to print everything
         */
        static void PrintAllElements()
        {
            foreach(int age in playerAges)
                Console.WriteLine(age);
        }

        /*
         *  Q5 Reverse Items in Array
         */
        static void Reverse()
        {
            for(int i = playerAges.Length - 1; i >=0; i--)
                Console.WriteLine(playerAges[i]);
        }

        /*
         *  Q6 Average of all ages in array
         */
        static double Avergae()
        {
            return playerAges.Average();

            //or
            //return playerAges.Sum / playerAges.Length;
        }

        /*
         *  Q7 Look for a value in array
         */
        static bool Search(int target)
        {
            return playerAges.Contains(target);
        }

        /*
         *  Q8 Reverse items
         */
        static void ReverseOrder()
        {
            playerAges.Reverse();
        }

        /*
         *  Q9 Multiplication of Arrays
         */
        static int ArrayMultiplication()
        {
            int accumulator = 0;
            int[] numbers = {5,7,6,5,4,3};

            for (int i = 0; i < playerAges.Length; i++)
                accumulator += playerAges[i] * numbers[i];

            return accumulator;
        }
    }
}
