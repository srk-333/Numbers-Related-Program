using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Numbers Related Program");
            UserStringChange.userInput(); //calling static method of UserStringChange Class
            FlipCoin.CoinFlip();  //calling static method of CoinFlipass
            Factors.FactorOfNumber();  //calling static method of Factors class
            HarmonicNumber.PrintHarmonicNumber();  //calling static method of HarmonicNumber class
            PowerOfTwo.GetPowerOfTwo();  //calling static method of PowerOfTwo class 
            Console.ReadLine();
        }
    }
}
