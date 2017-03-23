using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Part_2_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            double initalBal, savingAmount, finalBal;
            int numberOfYears, numberOfMonths;
            const double MONTHLY_INTEREST_RATE = 1.01;

            //Input
            Console.Write("Enter initial amount: ");
            initalBal = double.Parse(Console.ReadLine());
            Console.Write("Enter monthly saving amount: ");
            savingAmount = double.Parse(Console.ReadLine());
            Console.Write("Enter a number of years you wish to save: ");
            numberOfYears = int.Parse(Console.ReadLine());

            //Processing
            numberOfMonths = numberOfYears * 12;
            finalBal = initalBal;

            for (int i = 1; i <= numberOfMonths; i++)
            {
                if (i == 1)
                {
                    finalBal *= MONTHLY_INTEREST_RATE;
                }
                else
                {
                    finalBal += savingAmount;
                    finalBal *= MONTHLY_INTEREST_RATE;
                }
                Console.WriteLine(finalBal.ToString("n2"));
            }

        }
    }
}
