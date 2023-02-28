namespace Task_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            while (true) {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    numbers.Add(number);

                    Console.WriteLine($"Кол-во чисел в списке: {numbers.Count}\n" +
                                      $"Сумма всех чисел: {numbers.Sum()}\n" +
                                      $"Наибольшее число: {numbers.Max()}\n" +
                                      $"Наименьшее число: {numbers.Min()}\n" +
                                      $"Среднее значение: {numbers.Average():f2}");
                }
                else
                    Console.WriteLine("Вы ввели не число!");

                Console.WriteLine(new string('-', 50));
            }
        }
    }
}