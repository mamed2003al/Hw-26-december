using System;
using System.Collections.Generic;
using System.Text;

namespace _26_december_HW
{
    internal class User
    {
        private string _username;
        private string _password;

        public User(string name)
        {

        }
        public string UserName
        {
            get => _username;
            set
            {
                if(value.Length <=6 && value.Length >= 25)
                {
                    _username = value;
                }
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    if (HasDigit(value) && HasUpper(value) && HasLower(value) && value.Length >=8 && value.Length <= 25)
                    {
                        _password = value;
                    }
                }
            }
        }
        public bool HasLower(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasDigit(string str)
        {
            for (int i=0; i<str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }


}
