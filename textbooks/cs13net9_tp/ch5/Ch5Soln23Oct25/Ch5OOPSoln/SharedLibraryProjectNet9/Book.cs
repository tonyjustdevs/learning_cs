using System.Diagnostics.CodeAnalysis;
namespace TP.SharedNamespace;

public class Book
{
    public required string? BookName;
    public required int ISBN;
    public string? Author;
    public int PageCount;
}
public class Book2
{
    public string? BookName;
    public int ISBN;
    public string? Author;
    public int PageCount;

    public Book2() { } // object initialisation syntax

    [SetsRequiredMembers]
    public Book2(string name, int isbn) {
        BookName = name;
        ISBN = isbn;
    }

}
