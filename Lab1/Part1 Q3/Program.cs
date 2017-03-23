using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int examScore;
            int total = 0, count = 0;

            Console.Write("Enter score : ");
            examScore = int.Parse(Console.ReadLine());

            while (examScore != -999)
            {

                total += examScore;
                count++;

                Console.Write("Enter score : ");
                examScore = int.Parse(Console.ReadLine());


            }
            double avg = total / count;
            Console.WriteLine("average is {0}", avg);

        }
    }
}
