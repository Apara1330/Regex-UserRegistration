﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_UserRegistration
{
     class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello..");
            ValidateUserRegistration validateUserRegistration = new ValidateUserRegistration();
            /*Console.WriteLine("Enter valid first name : ");
            string firstName = Console.ReadLine();
            validateUserRegistration.ValidateFirstName(firstName);
*/
            /*Console.WriteLine("Enter valid last name : ");
            string lastName = Console.ReadLine();
            validateUserRegistration.ValidateLastName(lastName);*/

           /* Console.WriteLine("Enter valid EmailId");
            string mail = Console.ReadLine();
            validateUserRegistration.ValidateEmail(mail);*/
            

            Console.WriteLine("Enter mobile number");
            string mnum = Console.ReadLine();
            validateUserRegistration.ValidateMobile(mnum);
            Console.ReadLine();
        }
    }
}
