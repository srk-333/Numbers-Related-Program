using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class ComputeQuotientRemainder
    {
        /* Taking two number input from user
         * divide number to get quotient and remainder
         * compute quotient and remainder
         */
        public static void QuotienRemainder()
        {
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine()); 
            int quotient = firstNumber / secondNumber;
            int remainder = firstNumber % secondNumber;
            int result = quotient+ remainder;
            Console.WriteLine("Add of quotient and remainder is: " + result);
        }
    }
}
