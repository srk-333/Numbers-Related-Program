using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class AlphabetCheck
    {
        public static void VowelCheck()
        {
            Console.WriteLine("Enter Alphabet to check vowel or consonant");
            string alph = Console.ReadLine();
            if (alph == "A"||alph == "a"||alph == "E"||alph == "e"||alph == "I"||alph == "i"||alph == "O"||alph == "o"||alph == "U"||alph == "u")
            {
                Console.WriteLine(alph + ": is a vowel");
            }
            else
            {
                Console.WriteLine(alph + ": is a Consonant");
            }
        }
    }
}
