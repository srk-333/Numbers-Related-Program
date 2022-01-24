﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Numbers Related Program");

            Program program = new Program();
            program.MethodInvoke();
            Console.ReadLine();
        }
        //Method to Get Option to run program.
        public void MethodInvoke()
        { 
            bool CONTINUE = true;
            //Loop to select Option.
            while (CONTINUE)
            {
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1=UserStringChange, 2=FlipCoin, 3=Factors, 4=HarmoincNumber, 5=PowerOfTwo");
                Console.WriteLine("6=SwapTwoNumbers, 7=LeapYear, 8=AlphabetCheck, 9=EvenOddCheck, 10=LargestNumber");
                Console.WriteLine("11=FibonacciSeries, 12=ReverseNumber, 13=PerfectNumber, 14=PrimeNumber, 15=SquareRoot");
                Console.WriteLine("16=MonthlyPayment, 17=TemperatureConversion, 18=QuotientRemainder, 19=CouponNumbrs, 0=Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        UserStringChange.userInput();
                        break;
                    case 2:
                        FlipCoin.CoinFlip();
                        break;
                    case 3:
                        Factors.FactorOfNumber();
                        break;
                    case 4:
                        HarmonicNumber.PrintHarmonicNumber();
                        break;
                    case 5:
                        PowerOfTwo.GetPowerOfTwo();
                        break;
                    case 6:
                        SwapTwonumbers.SwapNumbers();
                        break;
                    case 7:
                        LeapYear.FindLeapYear();
                        break;
                    case 8:
                        AlphabetCheck.VowelCheck();
                        break;
                    case 9:
                        EvenOddCheck.OddEvenCheck();
                        break;
                    case 10:
                        LargestNumber.CheckLargestNumber();
                        break;
                    case 11:
                        FibonacciSeries.FabSeries();
                        break;
                    case 12:
                        ReverseNumber.RevNumber();
                        break;
                    case 13:
                        PerfectNumber.GetPerfectNumber();
                        break;
                    case 14:
                        PrimeNumber.UserInput();
                        break;
                    case 15:
                        SquareRoot.Sqrt();
                        break;
                    case 16:
                        MonthlyPayment.Payment();
                        break;
                    case 17:
                        Temperature.TemperatureConversion();
                        break;
                    case 18:
                        ComputeQuotientRemainder.QuotienRemainder();
                        break;
                    case 19:
                        CouponNumbers couponNumbers = new CouponNumbers();
                        int count = couponNumbers.GenerateDistinct();
                        Console.WriteLine("NO of Distinct Coupons Generated: "+count);                      
                        break;
                    default:
                        CONTINUE = false;
                        break;
                }
            }
        }
    }
}