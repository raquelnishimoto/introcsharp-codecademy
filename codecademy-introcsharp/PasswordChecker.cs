using System;
using System.Text.RegularExpressions;

/*
* A strong password:
* is at least 8 characters long
* has lowercase letters
* has uppercase letters
* has numerical digits
* has symbols, like #, ?, !

* log different messages for different scores:

* For scores of 4 and 5, the password is extremely strong
* For scores of 3, the password is strong
* For scores of 2, the password is medium
* For scores of 1, the password is weak
* If none of those match, the password doesn’t meet any of the standards
*/

namespace PasswordChecker
{
    class Project
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "[A-Z]";
            string lowercase = "[a-z]";
            string digits = "\\d";
            string specialChars = "[^a-zA-Z\\d]";
            int score = 0;

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            if (password.Length >= minLength)
            {
                score += 1;
            }
            if (Regex.Matches(password, uppercase).Count > 0)
            {
                score += 1;
            }
            if (Regex.Matches(password, lowercase).Count > 0)
            {
                score += 1;
            }
            if (Regex.Matches(password, digits).Count > 0)
            {
                score += 1;
            }
            if (Regex.Matches(password, specialChars).Count > 0)
            {
                score += 1;
            }

            switch (score)
            {
                case 4:
                case 5:
                    Console.WriteLine("Password is very strong.");
                    break;
                case 3:
                    Console.WriteLine("Password is strong.");
                    break;
                case 2:
                    Console.WriteLine("Password is medium.");
                    break;
                case 1:
                    Console.WriteLine("Password is weak.");
                    break;
                default:
                    Console.WriteLine("Password does not meet any standards");
                    break;
            }
        }
    }
}