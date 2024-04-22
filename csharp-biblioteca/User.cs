using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class User
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        int Phone {  get; set; }

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
