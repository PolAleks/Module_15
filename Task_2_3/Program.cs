namespace Task_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static double Average(int[] numbers)
        {
            return numbers.Sum() / (double)numbers.Length;
        }
    }
}