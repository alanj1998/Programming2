using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            uint numberOfDays, startingNumber, percantage;
            double countedPercantage, total;
            bool organismCheck = true, percantageCheck = true, dayCheck = true;
            string format = "{0,-5}{1,-5}";

            //Input
            while (organismCheck == true && percantageCheck == true && dayCheck == true)
            {
                //Asking and checking the starting number of organisms
                Console.Write("Enter the starting number of organisms: ");
                organismCheck = uint.TryParse(Console.ReadLine(), out startingNumber);
                if (organismCheck == false)
                {
                    Console.WriteLine("Wrong value entered!");
                    Console.ReadKey();
                    organismCheck = true;
                    continue;
                }

                //Asking and checking the percantage increase
                Console.Write("Enter the daily average percantage increase: ");
                percantageCheck = uint.TryParse(Console.ReadLine(), out percantage);
                if (percantageCheck == false || percantage < 0)
                {
                    Console.Write("Wrong percantage value entered: ");
                    Console.ReadKey();
                    percantageCheck = true;
                    continue;
                }

                //Asking and checking the number of days
                Console.Write("Enter the amount of days allowed to multiply: ");
                dayCheck = uint.TryParse(Console.ReadLine(), out numberOfDays);
                if (dayCheck == false || numberOfDays < 0)
                {
                    Console.Write("Wrong value entered: ");
                    Console.ReadKey();
                    dayCheck = true;
                    continue;
                }

                //Processing
                countedPercantage = percantage / 100.0;
                total = startingNumber;

                //Output
                Console.WriteLine();
                Console.WriteLine(format, "Day", "Population Number");

                for (int day = 1; day <= numberOfDays; day++)
                {
                    total *= (1 + countedPercantage);
                    Console.WriteLine(format, day, Math.Round(total));
                }

                //Exiting app at the end
                Environment.Exit(0);
            }
        }
    }
}
