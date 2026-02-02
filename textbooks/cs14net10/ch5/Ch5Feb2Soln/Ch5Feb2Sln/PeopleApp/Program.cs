using Dumpify;
using TPNS.TPSharedLibModern;
using TPNS.TPSharedLibNet2;

using UnnamedParameters = (string, int);
using FruitQtyPriceAliasedTuple = (string, int, decimal);
using FruitAliasedTuples = (string fruit, int quantity);

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


// use methods
#region Methods1: return void
alice.WriteOriginToConsole();
var alice_origin_string = alice.GetOriginText();
WriteLine(alice_origin_string);
#endregion

#region Methods2: return text
alice.ParamsParameter("mate", [1, 2, 6, 40, 20]);
#endregion

var text_and_nbr = LifeTheUniverseAndEverything.GetData();

Console.WriteLine("{0} {1}", text_and_nbr.Text, text_and_nbr.Number);

Console.WriteLine("{0} {1}", 
    LifeTheUniverseAndEverything.GetData().Text,
    LifeTheUniverseAndEverything.GetData().Number);


#region Tuples_1: Unnamed, Named, Aliased 
(string, int) fruit = alice.GetFruit();
WriteLine("(unnamed 2-tuples): {0}, there are {1}", fruit.Item1, fruit.Item2);

UnnamedParameters fruit_aliased_tuple = alice.GetFruit(); //using UnnamedParameters = (string, int);
WriteLine("(unnamed 2-tuples-aliased): {0}, there are {1}", fruit_aliased_tuple.Item1, fruit_aliased_tuple.Item2);


(string, int, decimal) fruit2 = alice.GetUnnamedFruitV2();
WriteLine("(unnamed 3-tuples: {0}, there are {1}, ${2} per kg", fruit2.Item1, fruit2.Item2, fruit2.Item3);

FruitQtyPriceAliasedTuple fruit2_aliased_tuple = alice.GetUnnamedFruitV2(); //using FruitQtyPriceAliasedTuple = (string, int, decimal);
WriteLine("(unnamed 3-tuples-aliased: {0}, there are {1}, ${2} per kg", fruit2_aliased_tuple.Item1, fruit2_aliased_tuple.Item2, fruit2_aliased_tuple.Item3);


WriteLine("(named 2-tuples): {0}, there are {1}",
alice.GetFruitNamedTuples().fruit,
alice.GetFruitNamedTuples().quantity);


var fruit3 = alice.GetFruitNamedTuples();
WriteLine("(named 2-tuples-var: {0}, there are {1}",
fruit3.fruit, fruit3.quantity);

//using FruitAliasedTuples = (string fruit, int quantity);
FruitAliasedTuples fruit3_named_aliased = alice.GetFruitNamedTuples();

WriteLine("(named 2-tuples-aliased: {0}, there are {1}",
fruit3_named_aliased.fruit, fruit3_named_aliased.quantity);
#endregion

#region Tuples_1: Deconstructing 
//(string, int) fruit = alice.GetFruit();
//WriteLine("(unnamed 2-tuples): {0}, there are {1}", fruit.Item1, fruit.Item2);
(string alice_fruit, int alice_qty) = alice.GetFruit();
WriteLine("(named 2-tuples-deconstructing): {0}, there are {1}", alice_fruit, alice_qty);
#endregion  











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