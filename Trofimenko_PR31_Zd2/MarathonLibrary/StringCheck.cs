using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MarathonLibrary
{
    public class StringCheck
    {
        Regex regex;
        Match match;
        public bool EmailCheck(string emailString)
        {
            regex = new Regex(@"^[_a-z0-9-\+-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,})$");
            match = regex.Match(emailString);
            if (match.Success)
                return true;
            else
                return false;
        }

        public bool PasswordCheck(string passwordString)
        {
            regex = new Regex(@"(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%^&*]{6,}");
            match = regex.Match(passwordString);
            if (match.Success)
                return true;
            else
                return false;
        }

        public bool NameCheck(string nameString)
        {
            regex = new Regex(@"^[а-яА-Я\sa-zA-Z]$");
            match = regex.Match(nameString);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
