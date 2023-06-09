using System.Reflection.Metadata.Ecma335;

namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            MiddleCharacterPrint(input);
        }
        static string MiddleCharacterPrint(string input)
        {
            char first = ' ';
            char second = ' ';
            if (input.Length % 2 == 1)
            {
                first = (input[input.Length/2]);
            }
            else if (input.Length % 2 == 0)
            {
                second = (input[input.Length / 2]);
                first = (input[(input.Length / 2)-1]);
            }
            Console.WriteLine($"{first}{second}");
            return input;
        }
    }
}