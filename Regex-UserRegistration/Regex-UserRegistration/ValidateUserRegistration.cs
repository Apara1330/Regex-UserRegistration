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
        public const string First_Name = "^[A-Z][a-zA-Z]{2}";//first namepattern
        public const string Last_Name = "^[A-Z][a-zA-Z]{2}";//last name pattern
        public const string Email = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";//email pattern
        public const string Mobile = "^([9][1])+[ ]+[6789]{1}[0-9]{9}$";
        public const string PASSWORD = "^[a-z]{8}";


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
        public void ValidateLastName(string lastName)
        {
            //assigning pattern in regex constructor
            Regex regex = new Regex(Last_Name);

            if (regex.IsMatch(lastName))
            {
                Console.WriteLine("Last name is matched with pattern");
            }
            else
            {
                Console.WriteLine("Last name does not match with pattern");
            }
        }
        public void ValidateEmail(string emailId)
        {
            Regex regex = new Regex(Email);

            if (regex.IsMatch(emailId))
            {
                Console.WriteLine("Email matched with the pattern");
            }
            else
            {
                Console.WriteLine("Email does not match with the pattern");
            }

        }
        public void ValidateMobile(string MobNum)
        {
            
            Regex regex = new Regex(Mobile);

            if (regex.IsMatch(MobNum))
            {
                Console.WriteLine("Mobile Number is matched with pattern");
            }
            else
            {
                Console.WriteLine("Mobile Number does not match with pattern");
            }
        }
        public void ValidatePassword(string password)
        {
            Regex regex = new Regex(PASSWORD);

            if (regex.IsMatch(password))
            {
                Console.WriteLine("Password is matched with the pattern");
            }
            else
            {
                Console.WriteLine("Password does not match with the pattern");
            }
        }
    }
         
}
