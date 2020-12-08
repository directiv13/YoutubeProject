using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YoutubeProject.Validation
{
    class EmailValidator:IValidation
    {
        private static EmailValidator _instance;

        private string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        private string email;
        private EmailValidator(string email) 
        {
            this.email = email;
        }
        public static EmailValidator GetInstance(string email)
        {
            if (_instance == null)
            {
                _instance = new EmailValidator(email);
            }
            _instance.email = email;
            return _instance;
        }
        public bool IsSatisfied()
        {
            if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
