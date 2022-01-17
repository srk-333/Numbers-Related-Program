using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class Temperature
    {
        //static variable
        public static int temperature;
        /// <summary>
        /// Temperature Conversion method
        /// In this method, converting temerature in celsius and Fahrenheit using formulas.
        /// </summary>
        public static void TemperatureConversion()
        {
            Console.WriteLine("Enter Temperature");
            temperature = Convert.ToInt32(Console.ReadLine());
            int cTemp = (temperature - 32) * 5 / 9;      //converting temperature in Celsius and storing it in Local var cTemp
            Console.WriteLine("Given Temperature in Celsius: "+ cTemp + "\x00b0C");
            int fTemp = (temperature * 9 / 5) + 32;     //converting temperature in Fahrenheit and storing it in Local var fTemp
            Console.WriteLine("Given Temperature in Fahrenheit: "+ fTemp + "\x00b0F");
        }
    }
}