using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            uint speed, distance, time;
            bool speedCheck = true, timeCheck = true;
            string format = "{0,-5}{1,-20}";

            //Input
            while (speedCheck == true && timeCheck == true)
            {
                Console.Clear();
                Console.Write("Please enter the speed of the vehicle: ");
                speedCheck = uint.TryParse(Console.ReadLine(), out speed);
                if (speedCheck == false)
                {
                    Console.WriteLine("Wrong value entered!");
                    Console.ReadKey();
                    speedCheck = true;
                    continue;
                }
                
                Console.Write("Enter the time that the car has travelled: ");
                timeCheck = uint.TryParse(Console.ReadLine(), out time);
                if (timeCheck == false || time < 1)
                {
                    Console.WriteLine("Wrong value entered!");
                    Console.ReadKey();
                    timeCheck = true;
                    continue;
                }

                //Table Print Out
                Console.WriteLine();
                Console.WriteLine(format, "Hour", "Distance Travelled");
                for (int i = 1; i <= time; i++)
                {
                    distance = (uint)i * speed;
                    Console.WriteLine(format, i, distance);
                }

                //Closing the app at the end
                Environment.Exit(0);
            }
        }
    }
}
