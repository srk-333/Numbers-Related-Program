using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class HarmonicNumber
    {
        public static void PrintHarmonicNumber()
        {
            Console.WriteLine("Enter a number to print Harmonic Number");
            int number=Convert.ToInt32(Console.ReadLine());

            double harmonicSum = 0.0;
            if (number == 0)
            {
                Console.WriteLine("please enter positive number");
            }
            else
            {
                for (int count = 1; count <= number; count++)
                {
                    harmonicSum += 1 / (float)count;
                }
                Console.WriteLine("harmonic Number is: " + harmonicSum);
            }           
        }
    }
}
