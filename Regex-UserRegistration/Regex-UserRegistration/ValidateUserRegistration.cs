using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_UserRegistration
{
    public class ValidateUserRegistration
    {
        public const string First_Name = "^[A-Z][a-zA-Z]{2}";

        public void ValidateFirstName(string firstName)
        {
            Regex regex = new Regex(First_Name);

            if (regex.IsMatch(firstName))
            {
                Console.WriteLine("First name is matching with the pattern");
            }
            else
            {
                Console.WriteLine("First name is not matching with the pattern");
            }
        }
    }
}
