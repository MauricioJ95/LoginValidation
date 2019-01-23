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
            bool isValidInput = false, shouldContinue = false;
            do
            {
                shouldContinue = false;
                do
                {
                    Console.WriteLine("Please input an email in this format: example@example.com");
                    string email = Console.ReadLine();
                    isValidInput = ValidateUserEmail(email);
                } while (!isValidInput);

                isValidInput = false;

                do
                {
                    Console.WriteLine("Please input a password in with at least 1 capital letter and 1 number.");
                    string password = Console.ReadLine();
                    isValidInput = ValidateUserPassword(password);
                } while (!isValidInput);

                Console.WriteLine("Continue? y/n");
                string input = Console.ReadLine();
                if (input.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                {
                    shouldContinue = true;
                }
            } while (shouldContinue);
        }

        static List<string> emailList = new List<string> { };
        static List<string> passwordList = new List<string> { };

        public static bool ValidateUserEmail(string inputEmail)
        {

            bool isValidInput = false;
            try
            {
                if (!Regex.IsMatch(inputEmail, @"^[A-Za-z0-9_]{3,}@[A-Za-z0-9_]{3,}.[A-Za-z0-9_]{2,3}$"))
                {
                    throw new ArgumentException("Must input valid email address.");
                }
                emailList.Add(inputEmail);
                isValidInput = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return isValidInput;

        }

        public static bool ValidateUserPassword(string inputPassword)
        {

            bool isValidInput = false;
            try
            {
                if (!Regex.IsMatch(inputPassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{5,}$"))
                {
                    throw new ArgumentException("Must input valid password.");
                }
                passwordList.Add(inputPassword);
                isValidInput = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return isValidInput;
        }
    }
}
