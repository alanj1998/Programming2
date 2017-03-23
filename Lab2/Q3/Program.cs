using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            int score, qualificationVal;
            string message;

            //Input
            Console.Write("Enter your score: ");
            score = int.Parse(Console.ReadLine());
            qualificationVal = score / 10;

            //Process
            switch (qualificationVal)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    message = "Don't give up your day job dude!";
                    break;
                case 5:
                    message = "Back to the training ground dude!";
                    break;
                case 6:
                    message = "Some potential here dude!";
                    break;
                case 7:
                    message = "You're good dude!";
                    break;
                default:
                    message = "Awesome dude!";
                    break;
            }

            //Output Display
            Console.WriteLine(message);
        }
    }
}
