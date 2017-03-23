using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            double inputTemp, convertedTemp = 0;
            int tempChoice;

            //Input
            Console.WriteLine("Choose one of the following options:\n1) Celcius to Fahrenheit\n2) Fahrenheit to Celcius");
            tempChoice = int.Parse(Console.ReadLine());
            Console.Write("Enter the temperature to be converted: ");
            inputTemp = int.Parse(Console.ReadLine());
            
            //Process
            switch (tempChoice)
            {
                case 1:
                    convertedTemp = CelciusToFahrenheit(inputTemp);
                    break;
                case 2:
                    convertedTemp = FahrenheitToCelcius(inputTemp);
                    break;
                default:
                    Console.WriteLine("Wrong value entered!");
                    Environment.Exit(0);
                    break; 
            }

            //Output
            Console.WriteLine("The converted temperature is {0}.", convertedTemp.ToString("n1"));             
        }

        static private double FahrenheitToCelcius(double temperature)
        {
            temperature = (temperature - 32) / 1.8;

            return temperature;
        }

        static private double CelciusToFahrenheit(double temperature)
        {
            temperature = temperature * 1.8 + 32;

            return temperature;
        }
    }
}
