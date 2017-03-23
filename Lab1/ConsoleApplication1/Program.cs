using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int x = 0;

            while (x < 25)
            {
                sum += x + 5;
                x += 3;
            }

            Console.WriteLine(sum);
            Console.WriteLine(x);
        }
    }
}
