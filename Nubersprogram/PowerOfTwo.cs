using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class PowerOfTwo
    {
        public static void GetPowerOfTwo()
        {
            Console.WriteLine("Enter number to get power of two");
            int number = Convert.ToInt32(Console.ReadLine());
            int powOfTwo = 0;
            //check input number doesn't go above 30. 
            if (0 <= number && number < 31)
            {
                for (int i = 1; i <= number; i++)
                {
                    powOfTwo = (int)Math.Pow(2, i);
                    Console.WriteLine("2 ^ "+ i + " is:{0}", powOfTwo);
                }
            }
            else
                Console.WriteLine("Enter any number from 0 to 30");
        }
    }
}
