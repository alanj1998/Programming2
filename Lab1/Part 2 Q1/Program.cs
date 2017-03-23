using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            for (i = 1; i <= 20 ; i++)
            {
                Console.WriteLine(i);
            }

            i = 0;
            while (i < 21)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
