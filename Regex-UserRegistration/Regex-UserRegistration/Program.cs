using System;
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


            /*Console.WriteLine("Enter mobile number");
            string mnum = Console.ReadLine();
            validateUserRegistration.ValidateMobile(mnum);*/

            /*Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            validateUserRegistration.ValidatePassword(password);*/

            /*Console.WriteLine("Enter password with atleast one upper case: ");
            string password2 = Console.ReadLine();
            validateUserRegistration.ValidatePassword2(password2);*/

            /*Console.WriteLine("Enter password with atleast one numeric number: ");
            string password3 = Console.ReadLine();  
            validateUserRegistration.ValidaePassword3(password3);*/

            /*Console.WriteLine("Enter password with atleast one special character: ");
            string password4 = Console.ReadLine();
            validateUserRegistration.ValidatePassword4(password4);*/

            validateUserRegistration.ValidateSample();
            Console.ReadLine();
        }
    }
}
