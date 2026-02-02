using System.Diagnostics.CodeAnalysis;

namespace TPNS.TPSharedLibModern;

public class Book
{
    public required string Title;
    public required string Isbn;
    public string? Author;
    public int PageCount;

    [SetsRequiredMembers]
    public Book(string title, string isbn)
    {
        Title = title;
        Isbn = isbn;
    }
}

