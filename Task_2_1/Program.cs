namespace Task_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(6));
        }

        static long Factorial(int number)
        {
            int[] numbers = Enumerable.Range(1, number).ToArray(); 

            long result = numbers.Aggregate((a, b) => a * b);

            return result;
        }
    }
}