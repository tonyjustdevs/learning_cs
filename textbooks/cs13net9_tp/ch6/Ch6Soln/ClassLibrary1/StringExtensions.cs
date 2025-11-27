
using System.Text.RegularExpressions;

namespace TP.SharedLibraries;

public class StringExtensions
{
    public static bool isValidEmail(string email)
    {
        ArgumentException.ThrowIfNullOrEmpty(email);

        return Regex.IsMatch(email, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
    }
}

public static class StringExtensions2
{
    public static bool isValidEmail(this string email)
    {
        ArgumentException.ThrowIfNullOrEmpty(email);
        return Regex.IsMatch(email, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
    }
}
// Start:     60k
// bet 1:    125k 
// bet 2:    250k 
// bet 3:    500k
// bet 4:   1000k



