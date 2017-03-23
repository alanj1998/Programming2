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
            Console.WriteLine("The smallest number is {0}.", Smallest(6,3,2));
            Console.WriteLine("The average of the numbers is {0}.", Average(6, 4, 2));
            Console.WriteLine("Are the number the same? {0}.", Same(0,0,0));
            Console.WriteLine("Are these numbers different? {0}.", Diff(2,4,12));
            Console.WriteLine("Are these numbers sorted in order from smallest to biggest? {0}.", Sorted(1, 2, 4));
        }

        static int Smallest(int x, int y, int z)
        {
            if (x < y && x < z)
                return x;
            else if (x > y && y < z)
                return y;
            else
                return z;
        }

        static int Average(int x, int y, int z)
        {
            return (x + y + z) / 3;
        }

        static bool Same(int x, int y, int z)
        {
            return (x == y && y == z);
        }

        static bool Diff(int x, int y, int z)
        {
            return (x != y && x != z && y != z);
        }

        static bool Sorted(int x, int y, int z)
        {
            return (x < y && y < z);
        }
    }
}
