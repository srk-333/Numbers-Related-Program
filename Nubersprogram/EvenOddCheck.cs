using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class EvenOddCheck
    {
        /* Taking number Input from user
         * if number % 2 == 0 then it is even
         * else number is odd
         */
        public static void OddEvenCheck()
        {
            Console.WriteLine("Enter any Number");
            int number=Convert.ToInt32(Console.ReadLine());

            //condition
            if (number % 2 == 0)
            {
                Console.WriteLine(number + ": is a Even nunmber");
            }
            else
            {
                Console.WriteLine(number + ": is a odd number");
            }
        }
    }
}
