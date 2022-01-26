using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    public class VendingMachine
    {
        public static void GetChange()
        {
            Console.WriteLine("Enter Amount");
            int cash = Convert.ToInt32(Console.ReadLine());
            int temp = cash;
            int[] notes = {1000,500,100,50,10,5,2,1};
            //Loop to itearate till last notes 
            for (int i = 0; i < notes.Length; i++)
            {
                //Check Condition 
                if (cash >= notes[i])
                {
                    int noOfNotes = cash / notes[i];
                    cash %= notes[i];
                    Console.WriteLine("Type of Notes:"+ notes[i] +"*" +noOfNotes );
                }
                if (cash == 0)
                    break;
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Total cash:" + temp);
        }
    }
}
