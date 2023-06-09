namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            PrintAsciiSymbolsBetweenChars(input1, input2);

        }
        static void PrintAsciiSymbolsBetweenChars(char input1, char input2)
        {
            int a = input1;
            int b = input2;
            
            if (b < a)
            {
                a = input2;
                b = input1;
            }
            for (int i = a+1; i < b; i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
        }
    }
}