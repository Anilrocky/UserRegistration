using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class User
    {
        public const string NAME = "^[A-Z]{1}[a-z]{2,}$";
        public const string EMAIL = "^[a-zA-Z]{3,}[.]{0,1}[a-zA-Z]{0,}[@]{1}[a-zA-Z]{2,}[.]{1}[a-zA-Z]{2,}[.]{0,1}[a-zA-Z]{0,2}$";

        public string ValidateName(string name)
        {
            if (Regex.IsMatch(name, NAME))
                return "Valid";
            return "Invalid";
        }
        public string ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
                return "Valid";
            return "Invalid";
        }
    }
}