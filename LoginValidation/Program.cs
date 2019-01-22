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
            Console.WriteLine("Please input an email in this format: example@example.com");
            string email = Console.ReadLine();
            GetUserEmail(email);

            Console.WriteLine("Please input a password in with at least 1 capital letter and 1 number.");
            string password = Console.ReadLine();
            GetUserPassword(password);
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
                input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^[A-Za-z0-9_]{3,}@[A-Za-z0-9_]{3,}.[A-Za-z0-9_]{2,3}$"))
                {
                    email.Add(inputEmail);
                }
                else
                {
                    Console.WriteLine("Email not valid.");
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

                input = Console.ReadLine();
                if (!Regex.IsMatch(input, @"$^[A-z0-9]{5,}$"))
                {
                    password.Add(inputPassword);
                }
                else
                {
                    Console.WriteLine("Password not valid.");
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
