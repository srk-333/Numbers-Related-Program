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
            //Taking user input as string
            Console.WriteLine("Enter your username");
            String Name = Console.ReadLine();
            //Checking string length
            if (Name.Length >= 3)
            {
                //calling Method
                ReplaceGivenTemplate(Name);
            }
            else
            {
                Console.WriteLine("Please enter atleast 3 characters");
            }
        }
        // In method changing <UserName> from given Template with user input string
        public static void ReplaceGivenTemplate(String Name)
        {
            String Template = "Hello <UserName> , How are you?";
            if (Template.Contains("<UserName>"))
            {
                string result = Template.Replace("<UserName>", Name); //Replace method used to replace string with given new string.
                Console.WriteLine("After replace : " + result);
            }        
        }
    }
}
