
using System.Collections.Concurrent;
using System.Reflection.Metadata;
using TP.SharedLibraries;
// [1] create person instance 
Person hannah_instance = new Person() {
    Name = "Hannah",
    DOB = new DateTimeOffset(2000, 01, 01, 0, 0, 0, 0, TimeSpan.Zero)
};
Console.WriteLine("Welcome to '{0}'s Saigon Love Story",hannah_instance.Name);
hannah_instance.WriteToConsole();  

Console.WriteLine("before bangin");
hannah_instance.WriteKidsToConsole(); // get kiddo info   (#no kids)
// [2] create kiddos instance
List<Person> harry_kiddos = new() { 
    new Person(){Name="adolf"},
    new Person(){Name="ikea"},
    new Person(){Name="dryck!"}
};
hannah_instance.Children = harry_kiddos;

// [3] get person object info
Console.WriteLine("after bangin");
hannah_instance.WriteKidsToConsole(); // get kiddo info   (#no kids)

Console.WriteLine("'{0}' pre-marriage: {1}",hannah_instance.Name,hannah_instance.Spouses.Count);
Person.Marry(hannah_instance, new Person() { Name="mr raw"});
Console.WriteLine("'{0}' pos-marriage: {1}", hannah_instance.Name,hannah_instance.Spouses.Count);
Console.WriteLine("'{0}''s spouse-name: {1}", hannah_instance.Name, hannah_instance.Spouses[0].Name);

Console.WriteLine("To be continued...");

Person kim = new Person() { Name = "kim", DOB = new(2000, 01, 01, 0, 0, 0, TimeSpan.Zero) };

Console.WriteLine();
kim.WriteToConsole();
Console.WriteLine($"kim.isMarried: {kim.isMarried}, kim.Spouses.Count(): {kim.Spouses.Count()}");
Console.WriteLine("kim.Marry(new Person(){...} was run!");
kim.Marry(new Person() { Name = "danny boy", DOB = new(1990, 01, 01, 0, 0, 0, 0, TimeSpan.Zero) });
Console.WriteLine($"kim.isMarried: {kim.isMarried}, kim.Spouses.Count(): {kim.Spouses.Count()}");


//Console.WriteLine();
//Person anais    = new Person() { Name = "anais", DOB = new(2001, 01, 01, 0, 0, 0, TimeSpan.Zero) };
//Person jordana  = new Person() { Name = "jordana", DOB = new(2000, 01, 01, 0, 0, 0, TimeSpan.Zero) };

//anais.WriteToConsole();
//jordana.WriteToConsole();

//// use [MarriageService] to marry Anais and Jordana
//Person.MarryTwoPersons(anais, jordana);
//Person.MarryTwoPersons(anais, jordana);

//anais.MarryAPerson(jordana);
//jordana.MarryAPerson(anais);

//anais.WriteToConsole();
//jordana.WriteToConsole();

// 1. add old-school non-generic hash
// 2. add new-school generic hash

System.Collections.Hashtable my_hash_tbl = new();
my_hash_tbl.Add(1,  "aaa");
my_hash_tbl.Add(2,  "bbb");
my_hash_tbl.Add(3, "ccc");
my_hash_tbl.Add(kim, "ddd");
Console.WriteLine();
int chosen_key = 3;
Console.WriteLine($"key'{chosen_key}' has value: '{my_hash_tbl[chosen_key]}'");
Console.WriteLine($"key'{kim}' has value: '{my_hash_tbl[kim]}'");

Dictionary<int, string> my_dict = new();
my_dict.Add(1, "aaa");
my_dict.Add(2, "bbb");
my_dict.Add(3, "ccc");
my_dict.Add(kim, "ddd");
Console.WriteLine();

Console.WriteLine($"key'{chosen_key}' has value: '{my_dict[chosen_key]}'");
//Console.WriteLine($"key'{kim}' has value: '{my_dict[kim]}'"); // error : generic has type check






