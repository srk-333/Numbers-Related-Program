using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class PerfectNumber
    {
        /// <summary>Gets the perfect number.</summary>
        public static void GetPerfectNumber()
        {
            //First taking input from user.
            Console.WriteLine("Enter a number know perfect number");
            int number = int.Parse(Console.ReadLine());    //int.parse is used to convert string into integer.
            int sum = 0;    //Local variable
            /*iterating loop to get sum of all the perfect divisible number.
            *iterating loop till number/2 because we dont want last perfect divisible number
            *perfect divisible means remainder should be zero.
            */
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            //if condition is true then number is perfect number.
            if (sum == number)
                Console.WriteLine(number + "," + " Is a Perfect Number.");
            else
                Console.WriteLine(number + "," + " Is a not Perfect Number.");
        }
    }
}
