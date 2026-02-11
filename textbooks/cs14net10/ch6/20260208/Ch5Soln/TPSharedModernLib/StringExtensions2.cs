using System.Text.RegularExpressions; // To use Regex.
namespace TPSharedModernLib;

public static class StringExtensions2
{
    public static bool IsValidEmail2(this string email)
    {
        return Regex.IsMatch(email, 
            @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
    }
}
