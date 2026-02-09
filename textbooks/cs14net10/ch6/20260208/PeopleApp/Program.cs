using TPSharedModernLib;
//using Dumpify; // To use the Dump extension method.

#region [Section 0a] Add 'harry' ('Person' instance)
Person harry = new()
{
    Name = "Harry",
    Born = new(year: 2001, month: 3, day: 25,
    hour: 0, minute: 0, second: 0,
    offset: TimeSpan.Zero)
};
#endregion 

#region [Section 0] TextBook Code Samples

//harry.WriteToConsole();
// Implementing functionality using methods.
//Person lamech = new() { Name = "Lamech" };
//Person adah = new() { Name = "Adah" };
//Person zillah = new() { Name = "Zillah" };
//// Call the instance method to marry Lamech and Adah.
//lamech.Marry(adah);
//// Call the static method to marry Lamech and Zillah.
////Person.Marry(lamech, zillah);
////if (lamech + zillah)
////{
////    WriteLine($"{lamech.Name} and {zillah.Name} successfully got married.");
////}
//lamech.OutputSpouses();
//adah.OutputSpouses();
//zillah.OutputSpouses();
//// Call the instance method to make a baby.
//Person baby1 = lamech.ProcreateWith(adah);
//baby1.Name = "Jabal";
////WriteLine($"{baby1.Name} was born on {baby1.Born}");
//// Call the static method to make a baby.
//Person baby2 = Person.Procreate(zillah, lamech);
//baby2.Name = "Tubalcain";

//// Use the * operator to "multiply".

//Person baby3 = lamech * adah;
//baby3.Name = "Jubal";
//Person baby4 = zillah * lamech;
//baby4.Name = "Naamah";

//adah.WriteChildrenToConsole();
//zillah.WriteChildrenToConsole();
//lamech.WriteChildrenToConsole();
//for (int i = 0; i < lamech.Children.Count; i++)
//{
//    WriteLine(format: " {0}'s child #{1} is named \"{2}\".",
//      arg0: lamech.Name, arg1: i,
//      arg2: lamech.Children[i].Name);
//}

//lamech.Dump();


// Non-generic lookup collection.
//System.Collections.Hashtable lookupObject = new();
//lookupObject.Add(key: 1, value: "Alpha");
//lookupObject.Add(key: 2, value: "Beta");
//lookupObject.Add(key: 3, value: "Gamma");
//lookupObject.Add(key: harry, value: "Delta");

//int key = 2; // Look up the value that has 2 as its key.
//WriteLine(format: "Key {0} has value: {1}",
//  arg0: key,
//  arg1: lookupObject[key]);

//// Look up the value that has harry as its key.
//WriteLine(format: "Key {0} has value: {1}",
////  arg0: harry,
//  //arg1: lookupObject[harry]);

//// Define a generic lookup collection.
//Dictionary<int, string> lookupIntString = new();
//lookupIntString.Add(key: 1, value: "Alpha");
//lookupIntString.Add(key: 2, value: "Beta");
//lookupIntString.Add(key: 3, value: "Gamma");
////lookupIntString.Add(key: harry, value: "Delta");
//lookupIntString.Add(key: 4, value: "Delta");

//key = 3;
//WriteLine(format: "Key {0} has value: {1}",
//  arg0: key,
//  arg1: lookupIntString[key]);

#endregion

#region [Section 1] EventHandler
WriteLine("\n[Section 1] EventHandler");

harry.YellGood += MethodToBeHandled;
harry.YellGood += MethodToBeHandled2;

harry.YellBad += MethodToBeHandled;
harry.YellBad += MethodToBeHandled2;

//harry.YellBad += null;                              // ok but bad1
//harry.YellBad?.Invoke(harry, EventArgs.Empty);      // ok but bad2
//harry.YellGood ?.Invoke(harry, EventArgs.Empty);  // ce
//harry.YellGood = null;                            // ce2

harry.Poke();
harry.Poke();
harry.Poke();
#endregion

#region [Section 2a] Interfaces 'int' & 'string' Code Samples
WriteLine("\n[Section 2a] Interfaces Samples\n");
WriteLine("\nExisting 'int' and 'string' CompareTo()\n");
WriteLine("- [string] \"mate\".CompareTo(\"meat\"): {0}", "mate".CompareTo("meat"));
WriteLine("- [string] \"mate\".CompareTo(\"mate\"): {0}", "mate".CompareTo("mate"));
WriteLine("- [string] \"mates\".CompareTo(\"mate\"): {0}", "mates".CompareTo("meat"));

WriteLine($"- [int] 69.CompareTo(420): {69.CompareTo(420)}");
WriteLine($"- [int] 420.CompareTo(420): {420.CompareTo(420)}");
WriteLine($"- [int] 420.CompareTo(69): {420.CompareTo(69)}");
// string CompareTo
// int CompareTo
// Interfaces Section
#endregion

#region [Section 2b] Task 1: Create Interface 'Person' Sorter 
WriteLine("\n[Section 2b] Task 1: 'Person' Sorter" +
    "\nIn Program.Helpers.cs." +
    "\n1. define method partial Program class that outputs " +
    "\n2. all the names collection of people " +
    "\n3. passed as a parameter \n4. with a title beforehand");
#endregion

#region [Section 2c] Task 1: ShowPeopleNames(IEnumerable people)
ShowPeopleNames([
    new Person {Name="p1"},
    new Person {Name="p2"},
    new Person {Name="p3"},
    new Person {Name="p4"},
    new Person {Name="p5"}
]);
#endregion