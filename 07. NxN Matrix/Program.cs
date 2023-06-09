namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            MatrixMaker(n);
        }
        static void MatrixMaker(int n)
        { 
            for (int row = 1; row <= n; row++)
            {
                for(int col = 0; col < n; col++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }

    }
}