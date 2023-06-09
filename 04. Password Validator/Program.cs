using System.Diagnostics.Metrics;
using System.Linq.Expressions;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool lenhtCheck = false;
            bool ContentCheck = false;
            bool DigitCheck = false;

            if (PasswordLenghtCheck(input) == true)
            {
                lenhtCheck = true;
            } 
            
            if (PasswordContentCheck(input) == true)
            {
                ContentCheck = true;
            }
            if (PasswordDigitsCountCheck(input) == true)
            {
                DigitCheck = true;
            }

            if (lenhtCheck == true && DigitCheck == true && ContentCheck == true)
            { 
                    Console.WriteLine("Password is valid");
            }
        }
        static bool PasswordLenghtCheck(string input)
        {
            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }
        static bool PasswordContentCheck(string input)
        {
            string chars = "|!#$%&/()=?»«@£§€{}.-;'<>_,";
            for (int i = 0; i < input.Length; i++)
            {
                if (chars.Contains(input[i]))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }
            return true;
        }
        static bool PasswordDigitsCountCheck(string input)
        {
            string nums = "0123456789";
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (nums.Contains(input[i]))
                {
                    counter++;
                }
            }
            if (counter <= 1)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            return true;
        }
    }
}