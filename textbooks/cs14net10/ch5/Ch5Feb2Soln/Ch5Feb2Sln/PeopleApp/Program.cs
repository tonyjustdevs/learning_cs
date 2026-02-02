using Dumpify;
using TPNS.TPSharedLibModern;
using TPNS.TPSharedLibNet2;

ConfigureDumpify();

WriteLine("Welcome to PeopleApp");

Person bob = new() { Name = "bob", Born = new DateTimeOffset(1990, 1, 1, 0, 0, 0, TimeSpan.Zero) };

Person alice = new()
{
    Name = "alice",
    Born = new DateTimeOffset(2000, 6, 12, 0, 0, 0, TimeSpan.Zero),
    SportsFavourite = EnumSports.Snowboarding,
    SportsLiked = (EnumByteSports)69,
        
};

alice.Children.AddRange(new[]
{
    new Person {Name="Tommy"},
    new Person{Name="Angelica"},
    new Person{Name="Chuckie"},
});

bob.Dump();
alice.Dump(label: "alice instance (label)");

#region BookStuff

//Book harrypotter = new(){Title="harry potter 1", Isbn="asdf1234" };
Book harrypotter2 = new("happy potter 2", "asdf2222");
harrypotter2.Dump();
#endregion

Person blank_person = new();
WriteLine("{0} born in {1} at {2:hh:mm:ss.fff} on a {2:dddd}", 
    blank_person.Name,
    blank_person.HomePlanet,
    blank_person.Instantiated);
























// methods

//Array syntax

//var animals = new Animal?[] { .. }    
//Animal?[] animals = new() { .. }    ?
//List<string> names = ["Adam", "Barry", "Charlie"];
//string[] names = ["Adam", "Barry", "Charlie"];
//string[] names2 = { "Kate", "Jack", "Rebecca", "Tom" }; // array initailizer syntax

//string[,] grid1 = // Two dimensional array.
//{
//  { "Alpha", "Beta", "Gamma", "Delta" },
//  { "Anne", "Ben", "Charlie", "Doug" },
//  { "Aardvark", "Bear", "Cat", "Dog" }
//};

//string[,] grid2 = new string[3, 4]; // Allocate memory.
//grid2[0, 0] = "Alpha"; // Assign values.
//grid2[0, 1] = "Beta";

//string[][] jagged = // An array of string arrays.
//{
//  new[] { "Alpha", "Beta", "Gamma" },
//  new[] { "Anne", "Ben", "Charlie", "Doug" },
//  new[] { "Aardvark", "Bear" }
//};

//string[][] jagged = // An array of string arrays.
//[
//  [ "Alpha", "Beta", "Gamma" ],
//  [ "Anne", "Ben", "Charlie", "Doug" ],
//  [ "Aardvark", "Bear" ]
//];

//double[,] doubles = {
//  { 9.49, 9.5, 9.51 },
//  { 10.49, 10.5, 10.51 },
//  { 11.49, 11.5, 11.51 },
//  { 12.49, 12.5, 12.51 } ,
//  { -12.49, -12.5, -12.51 },
//  { -11.49, -11.5, -11.51 },
//  { -10.49, -10.5, -10.51 },
//  { -9.49, -9.5, -9.51 }
//};

// Allocate an array of 128 bytes.
//byte[] binaryObject = new byte[128];

//https://learning.oreilly.com/library/view/c-14-and/9781836206637/Text/Chapter_3.xhtml#_idParaDest-218
// object to string to base64