using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class SwapTwonumbers
    {
        /* perform swap Number Operation
         * take two input from user and store it in some variable
         * swap both input value of user with each other
         * like if x=10;and y=20;
         * then make it x=20; and y=10;
         */
        public static void SwapNumbers()
        {
            Console.WriteLine("Enter First Number");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int second=Convert.ToInt32(Console.ReadLine());
            SwapTwonumbers swap=new SwapTwonumbers(); //creating object of nonstatic Method.
            swap.PerformSwap(first, second); // calling PerformSwap Method using obj variable and passing it value of first and second.
        }
         /* creating a Method to Swap Number
          * in Method parameters catching value of first and second variablein f and s variables.
          * to swap Numbers creating a Temporary Variable
          * And in last Swapping both variable values with each other using Temp variable
          */
        public void PerformSwap(int f, int s)
        {
            int temp = 0;  
            Console.WriteLine("Number before swap first={0} and second={1}", f, s);
            temp = f; 
            f = s;    
            s = temp; 
            Console.WriteLine("Number After swap first={0} and second={1}", f, s);
        }
    }
}
