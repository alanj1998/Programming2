using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            double salary, tax;
            string martialStatus, restart = "Y";
            bool salaryCheck;

            while (restart == "Y")
            {
                //Resetting Vars
                Console.Clear();
                salary = 0; martialStatus = "";

                //Input
                Console.WriteLine("Tax Calculator");
                Console.WriteLine("This app will calculate your tax.");
                Console.WriteLine("First of all, your martial status is required.");
                Console.Write("Enter single or married: ");
                martialStatus = Console.ReadLine().ToUpper();

                if (martialStatus == "SINGLE" || martialStatus == "MARRIED")
                {
                    Console.Write("Now please enter your salary: ");
                    salaryCheck = double.TryParse(Console.ReadLine(), out salary);

                    if (salaryCheck)
                    {
                        //Process
                        switch (martialStatus)
                        {
                            case "SINGLE":
                                tax = Single(salary);
                                Console.WriteLine("Your tax for {0} euro salary is {1} euro.", salary, tax);
                                break;
                            case "MARRIED":
                                tax = Married(salary);
                                Console.WriteLine("Your tax for {0} euro salary is {1} euro.", salary, tax);
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Salary entered incorrectly!");
                }
                else
                    Console.WriteLine("Wrong option chosen!");

                Console.Write("Would you like to calculate again?(y/n) ");
                restart = Console.ReadLine().ToUpper();
            }
        }

        static double Single(double salary)
        {
            //Vars
            double tax;

            //Process
            if (salary < 8000)
                tax = salary * 0.10;
            else if (salary < 32000)
                tax = 800 + ((salary - 8000) * 0.15);
            else
                tax = 4400 + ((salary - 32000) * 0.25);

            return tax;
        }

        static double Married(double salary)
        {
            //Vars
            double tax;

            //Process
            if (salary < 16000)
                tax = salary * 0.10;
            else if (salary < 64000)
                tax = 1600 + ((salary - 16000) * 0.15);
            else
                tax = 8800 + ((salary - 64000) * 0.25);

            return tax;
        }
    }
}
