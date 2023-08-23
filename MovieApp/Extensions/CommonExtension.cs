namespace MovieApp.Extensions
{
    public static class CommonExtension
    {
        public static bool IsEmail(this string input) => !string.IsNullOrEmpty(input) && input.Contains('@');
    }
}
