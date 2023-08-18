namespace _00_Library
{
    public static class StringExtension
    {
        public static string FirstToUpper(this String str)
        {
            var firsPart = str.ToUpper().Substring(0, 1);
            var SecondPart = str.Substring(1);
            return firsPart + SecondPart;
        }
    }
}
