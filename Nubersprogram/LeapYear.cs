using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class LeapYear
    {
        /* conditio to know leap year.
         * if year is divisible by 4 and 400 then it is a Leap year
         * else if year is divisible by 100 then its not a leap year
         */
        public static void FindLeapYear()
        {
            //taking user Input and converting that input in integer value.
            Console.WriteLine("Enter year to know LeapYear or Not");
            int year = Convert.ToInt32(Console.ReadLine());

            //  First checking given year length
            if (year.ToString().Length != 4)
            {
                Console.WriteLine("Please enter in correct format of year");
            }
            else if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Year: " + year +" is a Leap year");
            }
            else
            {
                Console.WriteLine("Year: "+ year +" is not a Leap Year");
            }
            
        }
    }
}