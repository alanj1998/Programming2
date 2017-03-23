using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            int year;

            //Input
            Console.Write("Please input a year: ");
            year = int.Parse(Console.ReadLine());

            //Processing
            if (year < 1582)
            {
                if (year % 4 == 0)
                    Console.WriteLine("The year {0} is a leap year.", year);
                else
                    Console.WriteLine("The year {0} is not a leap year.", year);
            }
            else
            {
                if (year % 4 == 0 && year % 100 != 0 || (year % 400 == 0))
                    Console.WriteLine("The year {0} is a leap year.", year);
                else
                {
                    Console.WriteLine("The year {0} is not a leap year.", year);
                }
            }
        }
    }
}
