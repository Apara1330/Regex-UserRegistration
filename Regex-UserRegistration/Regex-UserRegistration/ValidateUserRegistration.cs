﻿using System;
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
        public const string PASSWORD_RULE2 = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        public const string PASSWORD_RULE3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        public const string PASSWORD_RULE4 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";


        //Declaring Array
        public string[] sample = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc-100@abc.net", "abc.100@abc.com.au",
                 "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,"abc","abc@.com","abc123@gmail.a", "abc123@.com" ,
                 "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a"};


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
        public void ValidatePassword2(string password2)
        {
            Regex regex = new Regex(PASSWORD_RULE2);

            if (regex.IsMatch(password2))
            {
                Console.WriteLine("Password is matching the pattern");
            }
            else
            {
                Console.WriteLine("Password is not matching the pattern");
            }
        }

        public void ValidaePassword3(string password3)
        {
            Regex regex = new Regex(PASSWORD_RULE3);

            if(regex.IsMatch(password3))
            {
                Console.WriteLine("Password is matching with the pattern");
            }
            else
            {
                Console.WriteLine("Password does not match with pattern");
            }

        }
        public void ValidatePassword4(string password4)
        {
            Regex regex = new Regex(PASSWORD_RULE4);

            if (regex.IsMatch(password4))
            {
                Console.WriteLine("Password is matching with the pattern");
            }
            else
            {
                Console.WriteLine("Password does not match with the pattern");
            }
        }

        public void ValidateSample()
        {
            Regex regex = new Regex(Email);
            for(int i = 0; i< sample.Length; i++)
            {
                if (regex.IsMatch((string)sample[i]))
                {
                    Console.WriteLine(sample[i]+" It is Valid");
                }
                else
                {
                    Console.WriteLine(sample[i] + "It is Invalid");
                }
            }
        }

    }
         
}
