using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone {  get; set; }

        public User(string name, string surname , string email, string password , int phone)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            Phone = phone;
        }

    }
}
