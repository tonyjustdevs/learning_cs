partial class Program
    {
    static string? GetAuthorName(bool isAuth = true)
    {
        if (isAuth)
        {
            return "old buddy";
        }
        return null;
    }

}
