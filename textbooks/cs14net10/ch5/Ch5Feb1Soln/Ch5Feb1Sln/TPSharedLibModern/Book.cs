using System.Diagnostics.CodeAnalysis;

namespace TPNS.TPSharedLibModern
{
    public class Book
    {
        public required string? Title;
        public required string? ISBN;
        public string? Author;
        public int WordCount;

        public Book(){ } //object initializer syntax 
        
        [SetsRequiredMembers]
        public Book(string? title, string? isbn) 
        {
            Title = title;
            ISBN = isbn;
        }

    }
}
