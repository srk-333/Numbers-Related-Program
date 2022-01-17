using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class PrimeNumber
    {
        /// <summary>
        /// Gets the prime number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public static bool GetPrimeNumber(int number)
        {
            /* 0 and 1 is not a prime number
             * if number is divisible by other than 1 and itself then its not a prime nnumber.
             * so iterating loop from 2 till number - 1
             */
            if (number == 0 || number == 1)
                return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Taking input from user and calling GetPrimeNumber method.
        /// </summary>
        public static void UserInput()
        {
            Console.WriteLine("Enter number to know prime number");
            int primeNumber = int.Parse(Console.ReadLine());
            //Used Ternary operator - if Method returns true then it will execute 1st statement otherwise 2nd statement. 
            Console.WriteLine(GetPrimeNumber(primeNumber) ? " prime number" : " not a prime number");
        }
    }
}
