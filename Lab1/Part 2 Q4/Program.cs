using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            int n1, n2, sum = 0;

            //Input
            Console.Write("Please enter the lower end of the values you want to add: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Now enter the upper limit: ");
            n2 = int.Parse(Console.ReadLine());

            //Processing
            while (n1 <= n2)
            {
                sum += n1;
                n1++;
            }

            if (sum > 500)
                Console.WriteLine("Sum is too large!");
            else
                Console.WriteLine("The sum is {0}.", sum);
        }
    }
}
