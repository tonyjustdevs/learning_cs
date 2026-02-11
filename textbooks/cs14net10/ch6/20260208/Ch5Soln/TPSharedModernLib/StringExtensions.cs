using System.Text.RegularExpressions; // To use Regex.
namespace TPSharedModernLib;

public class StringExtensions
{
    public static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, 
            @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
    }
}
