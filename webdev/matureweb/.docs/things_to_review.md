# Statements
- "The C# compiler can even translate the expression tree of a LINQ query into other forms – for example, when querying a database via LINQ to SQL or Entity Framework, the lambda expressions get converted to an SQL query sent to the database. This is powerful: you can use one unified querying syntax for in-memory collections, relational databases, XML (with LINQ to XML), and more."
    - Under the hood: LINQ works via deferred execution and iterators. Methods like Where and Select don’t immediately produce a result; they return an IEnumerable<T> that, when iterated, will yield the filtered or transformed results on the fly.
    - This means LINQ queries are memory-efficient (they don’t necessarily create new lists until you force an evaluation, e.g., by calling .ToList() or iterating in a foreach). It also means you can compose queries dynamically.
- Delegates enable us to be flexible in design, allowing us to swap behavior at runtime without changing our class structure.
- `MapStaticAssets`: has an issue with working with static HTML files when you have Visual Studio features like Browser Link and Hot Reload.

Misc:
- Combined with yield, the IEnumerable/IEnumerator interfaces implement the **Iterator pattern**.
- Events provide an implementation of the **Observer pattern**.
- Delegates offer a functional approach to **Strategy and Factory** patterns. 