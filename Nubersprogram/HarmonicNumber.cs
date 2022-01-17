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
            //check negative number
            if (number != 0)
            {
                Console.WriteLine("please enter positive number");
            }
            else
            {
                //loop to get all harmonic number sum.
                for (int count = 1; count <= number; count++)
                {
                    harmonicSum += 1 / (float)count;
                }
                Console.WriteLine("harmonic Number is: " + harmonicSum);
            }           
        }
    }
}
