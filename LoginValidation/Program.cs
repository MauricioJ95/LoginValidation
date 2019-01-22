using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static List<string> email = new List<string> { };
        static List<string> password = new List<string> { };

        public static string GetUserEmail(string inputEmail)
        {
            string input;

            bool isValidInput = false;
            do
            {
                isValidInput = true;

                Console.WriteLine("Please enter {0}", inputEmail);
                input = Console.ReadLine();
                if (!Regex.IsMatch(input, @"^[A-Za-z0-9_]{3,}@[A-Za-z0-9_]{3,}.[A-Za-z0-9_]{2,3}$"))
                {
                    Console.WriteLine("Email doesn't match specs, try again.");
                }
                else
                {
                    AddEmail();
                }

            } while (!isValidInput);
            return input;
        }

        public static string GetUserPassword(string inputPassword)
        {
            string input;

            bool isValidInput = false;
            do
            {
                isValidInput = true;

                Console.WriteLine("Please enter {0}", inputPassword);
                input = Console.ReadLine();
                if (!Regex.IsMatch(input, @"$^[A-z0-9]{5,}$"))
                {
                    Console.WriteLine("Email doesn't match specs, try again.");
                }
                else
                {
                    AddPassword();
                }

            } while (!isValidInput);
            return input;
        }
        public static void AddEmail()
        {
            email.Add(GetUserEmail("Email"));
        }
        public static void AddPassword()
        {
            password.Add(GetUserPassword("Password"));
        }
    }
}
