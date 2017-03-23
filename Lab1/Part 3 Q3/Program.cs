using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Vars
            string deliveryChoice;
            double weight, fee = 0;
            string repeat = "Y";
            bool weightCheck;

            //Input
            while (repeat == "Y")
            {
                Console.Clear();
                weight = 0; deliveryChoice = "";

                Console.WriteLine("Fee calculator");
                Console.WriteLine("Please select the type of delivery:");
                Console.WriteLine("R for Regular");
                Console.WriteLine("X for Express Delivery");
                Console.WriteLine("SX for Super Express Delivery");
                Console.WriteLine("SSX for Super Super Express Delivery");
                deliveryChoice = Console.ReadLine().ToUpper();

                if (deliveryChoice != "R" || deliveryChoice != "X" || deliveryChoice != "SX" || deliveryChoice != "SSX")
                    Console.WriteLine("You entered a wrong delivery choice!");

                else
                {
                    Console.WriteLine("You chose {0}.", deliveryChoice);
                    Console.Write("Please enter the weight of the package: ");
                    weightCheck = double.TryParse(Console.ReadLine(), out weight);

                    if (weightCheck)
                    {
                        //Process
                        switch (deliveryChoice.ToUpper())
                        {
                            case "R":
                                fee = Regular(weight);
                                Console.WriteLine("Your package of {0} grams with category {1} will cost you {2:n2} euro.", weight, deliveryChoice, fee);
                                break;
                            case "X":
                                fee = Express(weight);
                                Console.WriteLine("Your package of {0} grams with category {1} will cost you {2:n2} euro.", weight, deliveryChoice, fee);
                                break;
                            case "SX":
                                fee = SuperExpress(weight);
                                Console.WriteLine("Your package of {0} grams with category {1} will cost you {2:n2} euro.", weight, deliveryChoice, fee);
                                break;
                            case "SSX":
                                fee = SuperSuperExpress(weight);
                                Console.WriteLine("Your package of {0} grams with category {1} will cost you {2:n2} euro.", weight, deliveryChoice, fee);
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Wrong weight entered!");
                }

                //Output
                Console.Write("Would you like to go again? (y/n): ");
                repeat = Console.ReadLine().ToUpper();
            }
        }

        private static double Regular(double grams)
        {
            //Var
            double price = 0;
            const double FLAT_CHARGE = 2.50, REGULAR_UNDER_2000 = 0.025, REGULAR_UNDER_5000 = 0.03, REGULAR_OVER_5001 = 0.05;
            
            //Processing
            if (grams <= 2000)
                price = FLAT_CHARGE + (grams * REGULAR_UNDER_2000);
            else if (grams <= 5000)
                price = FLAT_CHARGE + ((grams - 2000) * REGULAR_UNDER_5000 + (2000 * REGULAR_UNDER_2000));
            else
                price = FLAT_CHARGE + ((2000 * REGULAR_UNDER_2000) + (3000 * REGULAR_UNDER_5000) + (grams - 5000) * REGULAR_OVER_5001);
            return price;
        }

        private static double Express(double grams)
        {
            //Vars
            const double EXPRESS_CHARGE = 1.50;
            double price;

            //Processing
            price = Regular(grams) + EXPRESS_CHARGE;
            return price;
        }

        private static double SuperExpress(double grams)
        {
            //Vars
            const double SUPER_EXPRESS_CHARGE = 2.50;
            double price;

            //Processing
            price = Regular(grams) + SUPER_EXPRESS_CHARGE;
            return price;
        }

        private static double SuperSuperExpress(double grams)
        {
            //Vars
            const double SUPER_SUPER_EXPRESS_CHARGE = 3.50;
            double price;

            //Processing
            price = Regular(grams) + SUPER_SUPER_EXPRESS_CHARGE;
            return price;
        }
    }
}
