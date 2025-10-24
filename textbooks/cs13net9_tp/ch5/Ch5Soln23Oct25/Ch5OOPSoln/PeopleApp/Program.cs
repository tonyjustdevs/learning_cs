using System.Globalization;
using TP.SharedNamespace;
using Env =System.Environment;

Person p1 = new();
p1.Name = "mary";
p1.DOB = new DateTime(1990, 04, 01);
p1.Country = CountryEnum.Argentina;
p1.CountryBucketList = CountryEnumByte.UK | CountryEnumByte.Singapore; //40=8+32=2^3+2^5

Person sienna = new();
sienna.Name = "sienna";
p1.Children.Add(sienna);                                                                // method 1
p1.Children.Add(new Person() { Name = "jeff", DOB = new DateTime(2020, 08, 31) });      // method 2
p1.Children.Add(new() { Name = "darryl", DOB = new DateTime(2022, 04, 1) });      // method 2



Console.WriteLine($"Name: [{p1.Name}]");
Console.WriteLine($"DOB: [{p1.DOB}]");
Console.WriteLine($"Country: [{p1.Country}]");
Console.WriteLine($"BList: [{p1.CountryBucketList}][{(int)p1.CountryBucketList}] (exp: uk(4), sg(16))");
Console.WriteLine($"BList(69): {(CountryEnumByte)69} (exp: vn(1), uk(4), mad(64))"); // mada(64), uk(4), vn(1)
Console.Write($"Kiddos Count is {p1.Children.Count}: [");
var kiddos_IESTR = p1.Children.Select(kiddo => kiddo.Name); // IEnumerable<string>
//Console.WriteLine(kiddos_IESTR); //System.Linq.Enumerable+ListSelectIterator`2[Person,System.String]
//Console.WriteLine(typeof(kiddos_IESTR)); only works on types
//Console.WriteLine(kiddos_IESTR.GetType());
var kiddos_str = string.Join(", ", kiddos_IESTR);
Console.Write($"{kiddos_str}]\n");
BankAccount ba1 = new();
ba1.Balance = 69m;
Console.WriteLine($"ba1.bal: [{ba1.Balance}], BA.ir: [{BankAccount.InterestRate}] (pre)");
BankAccount.InterestRate = 1/3m;
Console.WriteLine($"ba1.bal: [{ba1.Balance}], BA.ir: [{BankAccount.InterestRate}] (pos)");
//In Program.cs, add statements to set the shared interest rate,
//and then create two instances of the BankAccount type

Console.WriteLine($"Person.Species: [{Person.Species}]");

Console.WriteLine();
Console.WriteLine($"Env.OSVersion: {Env.OSVersion}");
Console.WriteLine($"Env.CurrentDirectory: {Env.CurrentDirectory}");
Console.WriteLine($"Env.MachineName: {Env.MachineName}");

// 1. add class templates to existing soln 'Ch5OOPSoln'
// 2. create project 'SharedLibraryProjectNet9'
// 3. rename Class1.cs -> Book.cs
// 4. create Class Book with required mbrs and non-required mbrs
// 5. create Book instance in PeopleApp/Program.cs

Book HarryPotter = new()
{
    BookName = "Harry Potter & The Silver Camry",
    ISBN = 100
};
Console.WriteLine();
Console.WriteLine($"BookName: {HarryPotter.BookName}");
Console.WriteLine($"ISBN: {HarryPotter.ISBN}");

// 6. ADD CLS MBR:  'constant' field: Species 
// 7. ADD CLS MBR:  'readonly' field: HomePlanet

Console.WriteLine($"const Person.Species2: {Person.Species2}");
Console.WriteLine($"reaonly p1.ClosestStar: {p1.ClosestStar}");

// 8.   add constructor with default 2 field values:
// 8.1  Name="Unknown"
// 8.2  Instantiated =...;
// 8.3  create default person
// 8.4  + print & validate: [Name] & [Instantiated]

Person regular_person = new();
Console.WriteLine();
Console.WriteLine($"regular_person.Name: {regular_person.Name}");
Console.WriteLine($"regular_person.Instantiated: {regular_person.Instantiated} on {regular_person.Instantiated} [unformated]");
Console.WriteLine($"regular_person.Instantiated: {regular_person.Instantiated:hh:mm:ss} on {regular_person.Instantiated:dddd} [formated]");