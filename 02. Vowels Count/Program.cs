namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VowelsCounter(input);
        }
        static void VowelsCounter(string input)
        {
            string vowels = "AEUIOaeuio";
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    counter++;
                }
            }
            
            
            Console.WriteLine(counter);
        }
    }
}