using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Part_2_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            int hours;
            double total = 0, charge;
            const double MINIMUM_FEE = 2.00, CHARGE_PER_HOUR = 0.50, MAXIMUM_FEE = 10.00;
            
            //Input
            Console.Write("Enter number of hours (-999 to quit): ");
            hours = int.Parse(Console.ReadLine());

            while (hours != -999)
            {
                if (hours <= 3)
                    charge = MINIMUM_FEE;
                else
                    charge = ((hours - 3) * CHARGE_PER_HOUR) + MINIMUM_FEE;

                if (charge > MAXIMUM_FEE)
                    total += MAXIMUM_FEE;
                else
                    total += charge;

                Console.WriteLine("Customer charge: {0:n2}.    Total Receipt: {1:n2}", charge, total);
                Console.Write("Enter number of hours (-999 to quit): ");
                hours = int.Parse(Console.ReadLine());
            }
        }
    }
}
