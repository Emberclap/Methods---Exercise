namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            SmallestNumber(number1, number2, number3);

        }
        static void SmallestNumber(int number1, int number2, int number3)
        {
            int SmallestNumber = 0;
            if (number1 >= number2)
            {
                SmallestNumber = number2;
            }
            else if (number1 <= number2)
            {
                SmallestNumber = number1;
            }
            if (SmallestNumber >= number3)
            {
                SmallestNumber = number3;
            }
            Console.WriteLine(SmallestNumber);
        }
    }
}