using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class ReverseNumber
    {
        /* In this program
         * we are taking number from user
         * and giving reverse of that number to user
         */
        public static void RevNumber()
        {
            //Taking number from user.
            Console.WriteLine("Enter number to reverse");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;    //Local Variable to store reverse number.
            //checking codition then repeating loop to get reverse number.
            while (number > 0)
            {
                int reminder = number % 10;             //remainder using modules (example- 123 % 10 = 3)
                reverse = (reverse * 10) + reminder;   //reversing number using formula.
                number /= 10;                         //dividing number to get new number from original number.
            }
            Console.WriteLine("Reverse number is: "+reverse);
        }
    }
}