using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    public class CouponNumbers
    {
        //static variable.
        static int N, random, value, count = 0, distinct = 0;
        //static Construtor.
        static CouponNumbers()
        {
            Console.WriteLine("Enter N distinct Value");
            N = Convert.ToInt32(Console.ReadLine());
        }
        //Method To Get all Distinct Coupon.
        public int GenerateDistinct()
        { 
            bool[] arr = new bool[N];  //bool Array.
            while (distinct < N)
            {
                random = new Random().Next(N);
                value = random;
                Console.WriteLine(value + " ");
                if (!arr[value]) 
                {
                    distinct++;
                    arr[value] = true;
                    Console.WriteLine(arr[value] + " ");
                }
                count++;
            }
             return count;
        }
    }
}