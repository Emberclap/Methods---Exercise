using System.Globalization;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());
           TopNumberFinder(input);
        }
        static void TopNumberFinder(int input)
        {
            
            for (int i = 1; i < input; i++)
            {
                
                for (int j = 0; j <= i; j++)
                {
                    int sumOfDigits = 0;
                    bool oddNumber = false;
                    int tempNumber = i;
                    while (tempNumber != 0)
                    {
                        int remainder = tempNumber % 10;
                        sumOfDigits += remainder;
                        tempNumber /= 10;
                        if (remainder % 2 == 1)
                        {
                            oddNumber = true;
                        }
                    }
                    if (sumOfDigits % 8 == 0 && oddNumber)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            
        }
    }
}