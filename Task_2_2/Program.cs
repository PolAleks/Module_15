namespace Task_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 79994500508 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675334 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };

            int correctPhone = contacts.Where(c => c.Phone.ToString().Length == 11 && c.Phone.ToString().StartsWith('7')).Count();

            int countCorrectPhone = (from contact in contacts
                                    let phone = contact.Phone.ToString()
                                    where phone.Length == 11 && phone.StartsWith('7')
                                    select contact)
                                    .Count();

            Console.WriteLine($"Кол-во корректных контактов через Extention методы Enumerable: {correctPhone}");
            Console.WriteLine($"Кол-во корректных контактов через LINQ запрос: {countCorrectPhone}");
        }
    }
}