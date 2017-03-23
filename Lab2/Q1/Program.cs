using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            int number;
            string day, repeat = "Y";
            bool dayCheck;

            //Looping until the user types n
            while (repeat.ToUpper() == "Y")
            {
                //Initialising Vars
                repeat = ""; day = "";

                //Input
                Console.Clear();
                Console.Write("Enter a number: ");
                dayCheck = int.TryParse(Console.ReadLine(), out number);

                //Check to make sure that the number entered is an integer
                if (!dayCheck)
                {
                    Console.WriteLine("Wrong value entered!");
                    repeat = "Y";
                }
                else
                {
                    switch (number)
                    {
                        case 1:
                            day = "Monday";
                            break;
                        case 2:
                            day = "Tuesday";
                            break;
                        case 3:
                            day = "Wednesday";
                            break;
                        case 4:
                            day = "Thursday";
                            break;
                        case 5:
                            day = "Friday";
                            break;
                        case 6:
                            day = "Saturday";
                            break;
                        case 7:
                            day = "Sunday";
                            break;
                        default:
                            Console.WriteLine("Wrong value entered!");
                            break;
                    }
                    Console.WriteLine("The number {0} corresponds to {1}.", number, day);
                }
                while (repeat != "Y" && repeat != "N")
                {
                    Console.WriteLine("Do you want to calculate again?(y/n): ");
                    repeat = Console.ReadLine().ToUpper().Trim();
                }
            }
        }
    }
}
