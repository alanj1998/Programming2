using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedQ2
{
    class Program
    {
        static void Main()
        {
            //Vars
            uint numberOfMonths = 0, totalRainfall = 0, numberOfYears, rainfall;
            double averageRainfall;
            bool numberOfYearsCheck, rainfallCheck;
            string format = "{0,-20}{1,-2}{2,-10}";

            //Input
            Console.Clear();
            Console.Write("Enter the number of years that the data was collected for: ");
            numberOfYearsCheck = uint.TryParse(Console.ReadLine(), out numberOfYears);
            if (numberOfYearsCheck == false || numberOfYears == 0)
            {
                Console.WriteLine("Wrong value entered for years!");
                Console.ReadKey();
                Main();
            }

            //Processing
            for (int year = 1; year <= numberOfYears; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    Console.WriteLine("Enter the rainfall in inches for year {0} month {1}.", year, month);
                    rainfallCheck = uint.TryParse(Console.ReadLine(), out rainfall);
                    if (rainfallCheck == false)
                    {
                        Console.WriteLine("The value you entered is incorrect!");
                        month--;
                        Console.ReadKey();
                        continue;
                    }
                    numberOfMonths++;
                    totalRainfall += rainfall;
                }
            }
            averageRainfall = totalRainfall / numberOfMonths;

            //Output
            Console.WriteLine();
            Console.WriteLine(format, "Number of Months", ":", numberOfMonths);
            Console.WriteLine(format, "Total Rainfall", ":", totalRainfall);
            Console.WriteLine(format, "Average Rainfall", ":", averageRainfall);
        }
    }
}
