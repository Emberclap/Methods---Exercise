namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            while (command != "END")
            {
                int number = int.Parse(command);
                if (PalindromeChecker(command) == number)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
            }

        }
        static int PalindromeChecker(string command)
        {
            int number = int.Parse(command);
            int reversedNumber = 0;
            
            while (number != 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }
            
            return reversedNumber;
        }
    }
}