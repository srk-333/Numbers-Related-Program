using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    public class ToBinary
    {
        //static variables 
        static int decimalValue, remainder;
        static string binary;
        static ToBinary()
        {
            Console.WriteLine("Enter the Decimal Value");
            decimalValue = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// convert value to binary
        /// </summary>
        public static void ConvertToBinary()
        {
            do
            {
                remainder = decimalValue % 2;
                binary = remainder + binary;
                decimalValue /= 2;
            } while (decimalValue != 0);
            Console.WriteLine("Binary Number:" + binary);
        }
    }
}