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
            for (int i = 1; i <= number; i++)
            {
                powOfTwo =(int) Math.Pow(2, i);
            }
            Console.WriteLine("Power of given number: " + powOfTwo);
        }
    }
}
