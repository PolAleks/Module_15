namespace Task_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

            //var group = from contact in phoneBook
            //            let gr = contact.Email
            //            group contact by gr.Substring(gr.IndexOf('@') + 1);

            var group = phoneBook.GroupBy(g => g.Email.Split('@').Last());

            foreach (var gr in group)
            {
                if(gr.Key.Contains("example"))
                    Console.Write($"Фейковые аккаунты: ");
                else
                    Console.Write("Реальные аккаунты: ");

                Console.WriteLine(gr.Key);

                foreach (var contact in gr)
                {
                    Console.WriteLine($"{contact.Name} с email адресом {contact.Email}");
                }
            }

        }
    }
}