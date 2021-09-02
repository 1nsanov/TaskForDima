using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test123
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public User(string name, int age, string email)
        {
            Name = (char.ToUpper(name[0]) + name.Substring(1));
            Age = age;
            Email = email;
        }

        public override string ToString()
        {
            return $"Я {Name}, мне {Age}. Моя почта: {Email}."; 
        }

    }
}
