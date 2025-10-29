//using System.Globalization;
//using System.Numerics;
//using System.Reflection.Metadata;
//using System.Xml.Linq;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;
using TP.SharedNamespace;
using AliasedColorNmTPL = (int colorid, string colorname);
using CareerNmTplAlias = (string JobTitle, bool Employed);
using Env =System.Environment;
using FruitNamedTupleAlias  = (string Fruit, short Number); // unamed tuple
using FruitUnamedTupleAlias = (string, short); // unamed tuple

Person p1 = new()
{
    Name = "mary",
    DOB = new DateTime(2025, 12, 25),
    Country = CountryEnum.Argentina,
    CountryBucketList = CountryEnumByte.UK | CountryEnumByte.Singapore //40=8+32=2^3+2^5
};

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


// anonymouse tuples
var mate420 = ("mate", 420);

Console.WriteLine("anonymous tuples 1");
Console.WriteLine($"mate420.Item1: {mate420.Item1}, mate420.Item2: {mate420.Item2}");
Console.WriteLine("anonymous tuples 2: name inference");

var AnonNamedTuples = (p1.Name, p1.Children.Count);

Console.WriteLine($"AnonNamedTuples.Name: {AnonNamedTuples.Name}, AnonNamedTuples.Count: {AnonNamedTuples.Count}");

// create tuples with two aliased tuple types??
FruitUnamedTupleAlias RandomFruits = ("Rock melon", 222);
Console.WriteLine($"FruitUnamedTupleAlias obj.Item1: {RandomFruits.Item1}, obj.Item2: {RandomFruits.Item2}"); 

//FruitNamedTupleAlias RandomNamedFruits = (Fruit: "Water melon", Value: 333);
Console.WriteLine($"FruitNamedTupleAlias obj.Item1: {RandomFruits.Item1}, obj.Item2: {RandomFruits.Item2}");
//using FruitNamedTupleAlias  = (string Fruit, short Number); // unamed tuple
FruitNamedTupleAlias NamedFruits = new() {
    Fruit = "Strawberries", 
    Number = 321
};

Console.WriteLine($"Using FruitNamedTupleAlias: obj.Fruit: {NamedFruits.Fruit}, obj.Number: {NamedFruits.Number}") ;
CareerNmTplAlias TonyWorker1 = new("A bum", false);
Console.WriteLine($"TonyWorker1.JobTitle: {TonyWorker1.JobTitle}, TonyWorker1.Employed: {TonyWorker1.Employed}");

Console.WriteLine();
CareerNmTplAlias TonyWorker2 = new() { JobTitle="Developer", Employed=true};
Console.WriteLine($"TonyWorker2.JobTitle: {TonyWorker2.JobTitle}, TonyWorker2.Employed: {TonyWorker2.Employed}");

Console.WriteLine("getMessi() tuple deconstructed:");
(int ID_INT_Decon, string PLAYER_STR_Decon, long VAL_LNG_DECON) = p1.getMessi();
Console.WriteLine($"{ID_INT_Decon}, {PLAYER_STR_Decon},{VAL_LNG_DECON}");

// 'out' parameter cannot be initialised
// 'out` is passed [by-ref] + and [assigned]

string? nameTo=null;
DateTime? dobTo = null;
Console.WriteLine($"before decon() nameTo, dobTo: {nameTo}, {dobTo}");
Console.WriteLine($"og name, dob: {p1.Name},{p1.DOB}");
p1.Deconstruct(out nameTo, out dobTo);
Console.WriteLine($"after decon() nameTo, dobTo: {nameTo}, {dobTo}");

// return mult-vals via tuples
// create fn that creates tuple two 2 retvalues
// [1] anon cw tupler
Console.WriteLine($"p1.RandomRGBTupleReturner(): {p1.RandomRGBTupleReturner()}");
// [2] variable returned tupler
(int, string) color_str_tpl = p1.RandomRGBTupleReturner();
// [3] variable returned named tupler
(int colorid, string colorname) color_named_tpl = p1.RandomRGBTupleReturner();

Console.WriteLine($".colorid:{color_named_tpl.colorid}, .colorname: {color_named_tpl.colorname}");
// [4] aliased tuple????

AliasedColorNmTPL a_color_nmtple = p1.RandomRGBTupleReturner();
Console.WriteLine($"AliasedColorNmTPL obj: {a_color_nmtple}");

//AngelsFlaggedBytes tp_angel_bytes;
//List<Person> tp_kiddo_list;

// decon v1: verbosely
p1.DeconPersonObjAngelsKids(out AngelsFlaggedBytes tp_angel_bytes, out List<Person> tp_kiddo_list);
Console.WriteLine($"tp_angel_bytes from p1.DeconPersonObjAngelsKids(...): {tp_angel_bytes}");

Console.WriteLine($"tp_kiddo_list (type form): {tp_kiddo_list}"); //System.Collections.Generic.List`1[Person]

Console.WriteLine($"running static method: Person.PrintGenercListKiddoNames(tp_kiddo_list): ");
Person.PrintGenercListKiddoNames(tp_kiddo_list);

// decon v2 wiht proper types: 
//() p1
(string? decon_name, DateTime? decon_dob) = p1;
Console.WriteLine($"v2 decon-bracket-syntax: decon_name: {decon_name}, decon_dob: {decon_dob}");

// decon v3 with var
(var decon_name_var, var decon_dob_var) = p1;
Console.WriteLine($"v3 decon-bracket-syntax-wt-var: decon_name_var: {decon_name_var}, decon_dob_var: {decon_dob_var}");

// decon v4 with var
var (decon_name_var4, decon_dob_var4) = p1;
Console.WriteLine($"v4 decon_name: {decon_name_var4}, decon_dob: {decon_dob_var4}");


var classy_classer = new MyOtherClass();
Console.WriteLine("run classy_classer.GoToWork(): ");
classy_classer.GoToWork();

Console.WriteLine($"p1.Prop1_Origin: {p1.Prop1_Origin}");
Console.WriteLine($"p1.Prop2_Greeting: {p1.Prop2_Greeting}");
Console.WriteLine($"p1.Prop3_CalculatedAge: {p1.Prop3_CalculatedAge}");

Console.WriteLine($"(default) p1.FavouritePrimaryColor1:{p1.FavouritePrimaryColor1}");

Console.WriteLine($"(set & getted) p1.FavouritePrimaryColor1:{p1.FavouritePrimaryColor1}");

//p1.FavSport = "tennis";
//p1.FavSport = "pickleball";
//Console.WriteLine($"p1.FavSport:{p1.FavSport}");

//p1.FavFood_property = "pho";
//Console.WriteLine($"p1.FavFood_property: {p1.FavFood_property}");

// add try-except
// 1. try: {assign} var [chosen_sport] -> [p1.FavSport]
// 2. exc: {capture exception}
// - exc.msg pt[1]: nameof(p1.FavSport)
// - exc.msg pt[2]: [chosen_sport]
// - exc.msg pt[3]: ?
//string CHOSEN_FOOD = "salad";
string CHOSEN_FOOD = "eggplant";
try
{
    p1.FavFood_property = CHOSEN_FOOD;
}
catch (Exception ex)
{
    Console.WriteLine("Tried to assign Property '{0}' to '{1}' \nbut an ERROR occured & captured: '{2}'",
        nameof(p1.FavFood_property), CHOSEN_FOOD, ex.Message);
}
finally
{
    Console.WriteLine("finalised choosing....");
};

//List<Person.FavCities> matelist = new();

//List<Person.FavCities> matelist = new();
List<string?> cities_list = ["Saigon", "Sydney","kl", "da nang", "Bangkok"];
string? curr_city=null;
try
{

    foreach (string? city in cities_list)
    {
        Console.WriteLine($"Setting city: \t{city}");
        //curr_city = city;
        p1.FavCities = city;
        Console.WriteLine($"Current city: \t[{p1.FavCities}] (via p1.FavCities)\n");

    }
}
catch (Exception ex)
{
    Console.WriteLine("Tried to set {0} to {1} but failed: {2}", nameof(p1.FavCities), curr_city, ex.Message);
}
finally
{
    Console.WriteLine($"Current city: \t[{p1.FavCities}] (via p1.FavCities)\n");
}

// 1. [AGPerson.cs] create indexer of children
// 2. [AGPerson.cs] update indexer of children to search by name
// 3. [Person.cs] add children to person

//p1.Children.
Console.WriteLine();
var p1_kids_names_ie = p1.Children.Select(p => p.Name);
//p1_kids_names_ie.Join(,)
var kid_str = string.Join(", ", p1_kids_names_ie);

//Console.WriteLine($"kid_str.GetType(): {kid_str.GetType()}");
Console.WriteLine($"kid_str: '{kid_str}'");

Console.WriteLine($"p1[0].Name:{p1[0].Name}" +
    $"\np1[1].Name:{p1[1].Name}" +
    $"\np1[2].Name:{p1[2].Name}");
//'sienna, jeff, darryl'
var sienna_kiddo_object = p1["sienna"];

Console.WriteLine($"sienna_kiddo_object: {sienna_kiddo_object}");
Console.WriteLine($"sienna_kiddo_object.Name: {sienna_kiddo_object.Name}");

;
// p1[1]:TP.SharedNamespace.Person
// p1[0]:TP.SharedNamespace.Person,
//Console.WriteLine($"p1[0]:{p1[0]}, p1[1]:{p1[1]}");

// 4. [Person.cs] test res 1: using .Children[0] & .Children[1] 
// 4. [Person.cs] test res 2: using .Person[0] & .Person[1] 


// PRINT OBJECTS TO JSON
var options = new JsonSerializerOptions
{
    Converters = { new JsonStringEnumConverter() },
    WriteIndented = true
};

//string p1_json_str = JsonSerializer.Serialize(p1); // without enum strings
string p1_json_str = JsonSerializer.Serialize(p1, options);
Console.WriteLine(p1_json_str);

File.WriteAllText("person.json", p1_json_str); // Save to file