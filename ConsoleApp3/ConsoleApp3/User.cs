using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class User
    {
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        private int _id;
        public int Id { get => _id; }
        public User(string email,string password,string fullname)
        {
            _id++;
            Email = email;
            Password = password;
            Fullname = fullname;
        }

        public static bool PasswordChecker(string password, string value)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;

            if (!string.IsNullOrWhiteSpace(password))
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (value.Length > 7)
                    {
                        password = value;
                    }

                    if (char.IsDigit(password[i]))
                    {
                        hasDigit = true;
                    }
                    else if (char.IsLower(password[i]))
                    {
                        hasLower = true;
                    }
                    else if (Char.IsUpper(password[i]))
                    {
                        hasUpper = true;
                    }
                }
            }

            if (hasDigit == true && hasUpper == true && hasLower == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} - Fullname:{Fullname} - Email:{Email}");
        }
    }
}
