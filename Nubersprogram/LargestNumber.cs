using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class LargestNumber
    {
        /*Take input from user three numbers
         * compare all 3 numbers
         * result largest number in all three numbers.
         */
        public static void CheckLargestNumber()
        {
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            //condition
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("First number: "+firstNumber + " is the Largest number in all three numbers");
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("Second number: " + secondNumber + " is the Largest number in all three numbers");
            }
            else
            {
                Console.WriteLine("Third number: " + thirdNumber + " is the Largest number in all three numbers");
            }
        }
    }
}
