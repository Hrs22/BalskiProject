using System.Text.RegularExpressions;

namespace BalskiProject.Utilities
{
    public static class Validator
    {
        public static bool EmptyString(string value)
        {
            return string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
        }

        public static bool EmailLenght(string value)
        {
            return value.Length >= 8 && value.Length <= 18;
        }

        public static bool PasswordLength(string value)
        {
            return value.Length >= 4 && value.Length <= 12;
        }
        public static bool IsValidEmail(string Email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);
            return match.Success;
        }
    }
}
