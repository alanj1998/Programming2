using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            int quantity;
            double cost = 0;
            string productCode;
            const double OVER_500_DISCOUNT = 1.10;
            Console.OutputEncoding = Encoding.UTF8;

            //Input
            Console.Write("Enter the product code: ");
            productCode = Console.ReadLine();
            Console.Write("Enter the quantity of the product: ");
            quantity = int.Parse(Console.ReadLine());

            switch (productCode)
            {
               case "ASD":
                    cost += (quantity * 67.95);
                    break;
               case "THF":
                    cost += (quantity * 68.90);
                    break;
               case "TYG":
                    cost += (quantity * 34.95);
                    break;
                case "GHT":
                    cost += (quantity * 88.90);
                    break;
                case "YUR":
                    cost += (quantity * 23.80);
                    break;
                case "UIT":
                    cost += (quantity * 9.90);
                    break;
                case "HIT":
                case "UIP":
                case "RRT":
                case "JJK":
                case "IOP":
                    cost += (quantity * 10.00);
                    break;
                default:
                    Console.WriteLine("Wrong code entered!");
                    break;
            }

            if (cost > 500.00)
                cost /= OVER_500_DISCOUNT;

            Console.WriteLine("The cost of the product {0} in quantity of {1} is {2:c2}.", productCode, quantity, cost);
        }
    }
}
