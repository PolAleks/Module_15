namespace Task_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Привет";
            string str2 = "Праздник";

            char[] chars = GetCommonLetters(str1, str2);

            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }
        }

        static char[] GetCommonLetters(string str1, string str2) => str1.Intersect(str2).ToArray();

    }
}