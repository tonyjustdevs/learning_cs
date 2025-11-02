using System.Collections.Concurrent;
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
