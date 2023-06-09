using System.Reflection.Metadata.Ecma335;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            FactorialOfInput(input);
            Console.WriteLine($"{FactorialOfInput(input) / FactorialOfInput(input2):f2}");
        }
        static decimal FactorialOfInput(int input)
        {
            decimal factorial = 1;
            for (int i = input; i > 0 ; i--)
            {
                factorial *= i;
            }
            return factorial;
        }

    }
}