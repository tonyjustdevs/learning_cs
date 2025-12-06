using System.Globalization;
//OutputEncoding = System.Text.Encoding.UTF8; // Enable Euro symbol.
Console.WriteLine("Welcome to Culture & Strings App");

// [1]  get US culture
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

// [2]  add string 1 & 2
string nm1 = "mark";
string nm2 = "MARK";
Console.WriteLine($"Set en-US");
Console.WriteLine($"nm1:{nm1}, nm2:{nm2}");
// [3]  compare strings
Console.WriteLine($"[1a] comp(nm1,nm2): \t\t\t{string.Compare(nm1, nm2)}");

// [4]  compare strings: ignore cases
Console.WriteLine($"[2a] comp(nm1,nm2,ignoreCase): \t\t{string.Compare(nm1, nm2,ignoreCase:true)}");

// [5]  compare strings: InvariantCultureIgnoreCase
Console.WriteLine($"[3a] comp(nm1,nm2,SC.InvCIGCase): \t{string.Compare(nm1, nm2, StringComparison.InvariantCultureIgnoreCase)}");

//Console.WriteLine("[4] list all cultures:\n");
//int i=0;
//foreach (var culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
//{
//    Console.WriteLine($"[{i}]{culture}:\t{culture.DisplayName}");
//    i++;
//}
//nm1 = "Müller";
//nm2 = "Mueller";
nm1 = "Strasse";
nm2 = "Straße";
//Console.WriteLine($"\nSet en-US");
//Console.WriteLine($"[1b] comp(Müller,Mueller): \t{string.Compare(nm1, nm2)}");
//Console.WriteLine($"[2b] comp(Müller,Mueller,ignoreCase): \t\t{string.Compare(nm1, nm2, ignoreCase: true)}");
//Console.WriteLine($"[3b] comp(Müller,Mueller,SC.InvCIGCase): \t{string.Compare(nm1, nm2, StringComparison.InvariantCultureIgnoreCase)}");

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
Console.WriteLine($"\nSet de-DE");
Console.WriteLine($"[1b] comp(Strasse,Straße): \t{string.Compare(nm1, nm2, 
    culture: CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace)} [CompareOptions.IgnoreNonSpace]");

Console.WriteLine($"[2b] comp(Strasse,Straße): \t{string.Compare(nm1, nm2,
    culture: CultureInfo.CurrentCulture, 
    CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase)} [CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase)]");

Console.WriteLine($"[3b] comp(Strasse,Straße): \t{string.Compare(nm1, nm2, StringComparison.InvariantCultureIgnoreCase)} [StringComparison.InvariantCultureIgnoreCase)]");
Console.WriteLine($"[4b] comp(Straße,Strasse): \t{string.Compare(nm2, nm1, StringComparison.InvariantCultureIgnoreCase)} [StringComparison.InvariantCultureIgnoreCase)]");

// STRING ORDERING

Console.WriteLine("\n[String Ordering]\n");

// create string comparer
StringComparer string_comparer = StringComparer.Create(CultureInfo.CurrentCulture, CompareOptions.NumericOrdering);

//string_comparer.order

string[] operating_systems = new[] { "Windows 10", "Windows 11", "Windows 8" };

Console.Write("Un-Ordered oses: ");
foreach (var os in operating_systems){Console.Write($"'{os}', ");}
Console.Write("\nOrdered oses: ");
foreach (var os in operating_systems.Order(string_comparer)){Console.Write($"'{os}', "); }

