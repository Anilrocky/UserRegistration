using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class User
    {
        public const string NAME = "^[A-Z]{1}[a-z]{2,}$";
        public string ValidateName(string name)
        {
            if (Regex.IsMatch(name, NAME))
                return "Valid";
            return "Invalid";
        }
    }
}