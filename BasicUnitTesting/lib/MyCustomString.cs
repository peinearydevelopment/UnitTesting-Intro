using System.Text.RegularExpressions;

namespace lib
{
    public static class CustomString
    {
        public static bool IsNullOrWhiteSpace(string str)
        {
            return str == null || new Regex("^\\s*$").IsMatch(str);
        }
    }
}
