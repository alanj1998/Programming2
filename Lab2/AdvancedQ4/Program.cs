using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            const int NUMBER_OF_STORES = 5;
            int[] numberOfStars = new int[6], salesValue = new int[6];
            string format = "{0,-7}{1,-10}";

            //Input
            for (int i = 1;  i <= NUMBER_OF_STORES; i++)
            {
                Console.Write("Enter sales for store {0}: ", i);
                salesValue[i] = int.Parse(Console.ReadLine());
            }

            //Process
            for (int i = 1; i <= NUMBER_OF_STORES; i++)
            {
                numberOfStars[i] = salesValue[i] / 100;
            }

            //Output
            Console.WriteLine();
            for (int i = 1; i <= NUMBER_OF_STORES; i++)
            {
                Console.WriteLine(format, "Store" + i, "".PadRight(numberOfStars[i], '*'));
            }
        }
    }
}
