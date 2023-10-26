using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaskOverall.Exceptions;

namespace TaskOverall.Models
{
    internal class User
    {
        private static int _id;
        private string _name;
        private string _surname;
        public string Name
        {
            get => _name;
            set
            {
                if (Regex.IsMatch(value, "^[A-Z][a-zA-Z]*$"))
                {
                     _name = value;
                }
                else
                {
                    throw new InvalidNameException("Name is not valid ");
                }
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                if (Regex.IsMatch(value, "^[A-Z][a-zA-Z]*$"))
                {
                    _surname = value;
                }
                else
                {
                    throw new InvalidSurnameException("Surname  is not valid ");
                }
            }
        }
        public string UserName
        {
            get; private set;
            
            
        }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;

                }
                else
                {
                    throw new InvalidPasswordException("Password is not valid ");
                }

            }

        }


        public int Id
        {
            get;
            private set;
        }
        static User()
        {
            _id = 0;
        }
        public User( string name, string surname )
        {
            Name = name;
            Surname = surname;
            _id++;
            Id = _id;
            UserName = Name.ToLower() + "." + Surname .ToLower();
        }
        public static bool CheckPassword(string value)
        {
            // Validate strong password
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            return Regex.IsMatch(value, validateGuidRegex.ToString());


        }
        
    }
}
