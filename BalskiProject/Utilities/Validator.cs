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
            return value.Length >= 3 && value.Length <= 12;
        }

        public static bool PassowordLength(string value)
        {
            return value.Length >= 6 && value.Length <= 15;
        }
    }
}
