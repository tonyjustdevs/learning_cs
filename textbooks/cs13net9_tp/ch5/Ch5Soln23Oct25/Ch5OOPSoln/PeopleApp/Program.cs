using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Linq;
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

Book Spot = new Book
{
    BookName = "Spot",
    ISBN = 59
};

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

Console.WriteLine();

Person sailor_moon = new("sailor moon","moon");
Console.WriteLine($"sailor_moon.Name: {sailor_moon.Name} ");
Console.WriteLine($"sailor_moon.Planet: {sailor_moon.Planet} (via constructor)");
//Person sailor_moon = new Person {Name="sailor moon", Planet="moon"}; // Object Initializer , NOT constructor

Book2 LordOfTheRings = new(); //v1: initailisation syntax
LordOfTheRings.BookName = "LordOfTheRings";
LordOfTheRings.ISBN= 420;

Book2 SchindlersList = new("SchindlersList",666); // constructor
Console.WriteLine($"SchindlersList.BookName: {SchindlersList.BookName}");
Console.WriteLine($"SchindlersList.ISBN: {SchindlersList.ISBN}");

// 1. add methods region to Person cls


// 2. add a void method
// 3. add a str method
// 4. run each method
Console.Write($"Running Person instance void method p1.WriteToConsole()...: ");
p1.WriteToConsole();
Console.WriteLine($"Running instance str method p1.GetHomeInformation(): {p1.GetHomeInformation()}");

//WriteLine(p1.OptionalParameters(number: 52.7, command: "Hide!"));

BetterSavingsAccount better_account = new("jason bourne", 420.69M);
Console.WriteLine(better_account);

p1.Angels = AngelsFlaggedBytes.kim | AngelsFlaggedBytes.ana | AngelsFlaggedBytes.hana | AngelsFlaggedBytes.aira | AngelsFlaggedBytes.jordan;
Console.WriteLine($"p1.Angels: {p1.Angels} {(int)p1.Angels}");

// add person.field: collection of Angels
// add angel 1, 2, 3...
//int some_existing_int_var=123;
int some_existing_int_var=321;
int yet_another_existing_int_var=999;
const int some_vars = 70;

p1.PassingParams(ref some_existing_int_var, out yet_another_existing_int_var, 420, some_vars);

p1.PassingParamsParam("sum[1 to 5][commas]: ", 1, 2, 3, 4, 5); // v1: commas
Console.WriteLine();
p1.PassingParamsParam("sum[2,4,6][collection_expression]: ", [2, 4, 6]); // v1:

p1.PassingParamsParam("sum[3,4,5]: ", new int[]{4,5,6}); // v2
//p1.PassingParamsParam("sum[3,4,5]: ", new List<int> { 4, 5, 6 }); // v3
p1.FunctionWithParamsKeyword("FParams_1: commas", 10, 11, 12);
p1.FunctionWithParamsKeyword("FParams_2: collection expression", [50,51,52]);
p1.FunctionWithParamsKeyword("FParams_3: explicty array", new int[] {7,8,9 });
p1.FunctionWithParamsKeyword("FParams_4: 0", 0);


(string, int) cool_fruits = p1.getFruitTuple();
Console.WriteLine($"(string, int) cool_fruits : {cool_fruits}");

Console.WriteLine($"(string FruitName, int FruitNo) NamedTuple: {p1.getFruitNamedTuple()}");

var messi = p1.getMessi();
Console.WriteLine($"messi.ID: {messi.ID}, messi.soccerplayer: {messi.soccerplayer}, messi.val: {messi.valuation}");


