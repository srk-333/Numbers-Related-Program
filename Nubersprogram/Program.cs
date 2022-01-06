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
            UserStringChange.userInput();
            FlipCoin.CoinFlip();
            Console.ReadLine();
        }
    }
}
