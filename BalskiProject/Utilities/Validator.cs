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

        public static bool PassowordLength(string value)
        {
            return value.Length >= 4 && value.Length <= 12;
        }
    }
}
