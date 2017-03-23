using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
 
            for (int i = 1; i <= 5; i++)
                Console.WriteLine("".PadLeft(i, '#'));

            Console.WriteLine();

            for (int i = 5; i >= 0; i--)
                Console.WriteLine("".PadLeft(i, '#'));
        }
    }
}
