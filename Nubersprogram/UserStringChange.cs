using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nubersprogram
{
    internal class UserStringChange
    {
        public static void userInput()
        {
            Console.WriteLine("Enter your username");
            String Name = Console.ReadLine();

            if (Name.Length >= 3)
            {
                ReplaceGivenTemplate(Name);
            }
            else
            {
                Console.WriteLine("Please enter atleast 3 characters");
            }
        }

        public static void ReplaceGivenTemplate(String Name)
        {
            String Template = "Hello <UserName> , How are you?";
            if (Template.Contains("<UserName>"))
            {
                string result = Template.Replace("<UserName>", Name);
                Console.WriteLine("After replace : " + result);
            }        
        }
    }
}
