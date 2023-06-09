namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int sum = SumOfTwoNumbers(n, n2);
            SubtractOfTwoNumbers(sum, n3);

        }
        static int SumOfTwoNumbers(int n, int n2)
        {
            int sum = n +n2;
            return sum;

        }
        static int SubtractOfTwoNumbers(int n,int n3) 
        {
            int subtract = n - n3;
            
            Console.WriteLine(subtract);
            return subtract;
        }
    }
}