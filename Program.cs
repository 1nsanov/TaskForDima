using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test123
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"№{i + 1}");
                Console.WriteLine("Введите имя.");
                var name = InputName();
                Console.WriteLine("Введите свой возраст.");
                var age = InputAge();
                Console.WriteLine("Введите свою почту.");
                var email = InputEmail();
                Console.WriteLine();

                var user = new User(name, age, email);
                users.Add(user);
            }

            Console.WriteLine("Введите номер человека");
            var key = int.Parse(Console.ReadLine());
            Console.WriteLine(users.ElementAt(key - 1));

            Console.WriteLine();
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }


        private static string InputName()
        {
            while (true)
            {
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Имя не может быть пустым.");
                }
                else
                {
                    return name;
                }
            }         
        }
        private static int InputAge()
        {
            while (true)
            {
                var _age = Console.ReadLine();
                if (int.TryParse(_age, out int age) && age >= 18 && age <= 90)
                {
                    return age;
                }
                else
                {
                    Console.WriteLine($"Вам не может быть {age}");
                }
            }           
        }
        private static string InputEmail()
        {
            while (true)
            {
                string email = Console.ReadLine();
                if (email.Contains("@mail.ru") || email.Contains("@gmail.com") || email.Contains("@yandex.ru"))
                {
                    return email;
                    
                }
                else
                {
                    Console.WriteLine("Имя не может быть пустым или недопустимый формат почты.");                  
                }
            }
        }
    }
}
