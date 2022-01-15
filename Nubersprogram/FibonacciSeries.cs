using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class FibonacciSeries
    {
        //instance variables of static type
        public static int firstNum = 0, secondNum = 1, result = 0;

        // Creating method for Fibonacci Series
        public static void FabSeries()
        {
            // Taking User Input 
            Console.WriteLine("Please Enter Number to print fibonacci series");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User Number is :" + num);
            Console.WriteLine("FabSeries is : " + firstNum + "  " + secondNum);
            //iterating number to get all the fibonacci values
            for (int i = 2; i < num; i++)
            {
                result = firstNum + secondNum;
                Console.WriteLine("\t" + result);
                firstNum = secondNum;
                secondNum = result;
            }
        }
    }
}
