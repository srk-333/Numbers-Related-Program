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

            //calling static Method of all the classes created in this project.
            UserStringChange.userInput();
            FlipCoin.CoinFlip();
            Factors.FactorOfNumber();
            HarmonicNumber.PrintHarmonicNumber();
            PowerOfTwo.GetPowerOfTwo();
            SwapTwonumbers.SwapNumbers();
            LeapYear.FindLeapYear();
            AlphabetCheck.VowelCheck();
            EvenOddCheck.OddEvenCheck();
            LargestNumber.CheckLargestNumber();
            ComputeQuotientRemainder.QuotienRemainder();
            FibonacciSeries.FabSeries();
            ReverseNumber.RevNumber();
            PerfectNumber.GetPerfectNumber();
            PrimeNumber.UserInput();
            Temperature.TemperatureConversion();
            Console.ReadLine();
        }
    }
}