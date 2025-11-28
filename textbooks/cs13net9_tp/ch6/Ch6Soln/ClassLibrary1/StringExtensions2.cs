
using System.Text.RegularExpressions;

namespace TP.SharedLibraries
{
    public static class StringExtensionsTwo
    {
        public static bool isValidEmailOrNotStatic(string email) // static: dont need SETwo instance
        {
            return Regex.IsMatch(email, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
        public static bool isValidEmailOrNotExtMth(this string email) // static: dont need SETwo instance
        {
            return Regex.IsMatch(email, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
    }
}
