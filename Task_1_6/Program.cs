namespace Task_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enterData = Console.ReadLine();

            char[] symbol = { ',', '.', ';', ':', '?', '!', ' ' };

            char[] selectUnicSymbol = enterData.Except(symbol).Distinct().ToArray();

            Console.WriteLine(selectUnicSymbol);
        }
    }
}