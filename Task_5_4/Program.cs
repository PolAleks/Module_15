namespace Task_5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> instance = new List<int> { 1, 2, 3, 6, 9, 0, 5, 7 };

            var selectInstanse = instance.Where(n => n < 4);

            instance.Add(-1);

            foreach ( var i in selectInstanse )
            {
                Console.WriteLine(i);
            }
        }
    }
}