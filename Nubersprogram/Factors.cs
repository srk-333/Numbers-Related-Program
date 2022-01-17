using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class Factors
    {
        public static void FactorOfNumber()
        {
            //Taking input from user
            Console.WriteLine("Enter a Number to get factors");
            int Number=Convert.ToInt32(Console.ReadLine());
            int fact = 1;     //initializing fact with 1.
            //using loop to get all fctorial of a number
            for (int i = 1; i <= Number; i++)
            {
                fact = fact * i;   //multiply fact value with i.
            }
            Console.WriteLine("Factorial of given number is: " + fact);
        }
    }
}
