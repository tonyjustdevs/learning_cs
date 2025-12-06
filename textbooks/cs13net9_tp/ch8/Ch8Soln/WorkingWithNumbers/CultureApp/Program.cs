using System.Buffers;
using System.Globalization;
//OutputEncoding = System.Text.Encoding.UTF8; // Enable Euro symbol.
Console.WriteLine("Welcome to Culture & Strings App");

// [1]  get US culture
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

// [2]  add string 1 & 2
string nm1 = "mark";
string nm2 = "MARK";
Console.WriteLine($"[A] COMPARE STRINGS\n");
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

Console.WriteLine($"[B] STRING ORDERING\n");

// create string comparer
StringComparer string_comparer = StringComparer.Create(CultureInfo.CurrentCulture, CompareOptions.NumericOrdering);

//string_comparer.order

string[] operating_systems = new[] { "Windows 10", "Windows 11", "Windows 8","Windows 7-XP"};

Console.Write("Un-Ordered oses: ");
foreach (var os in operating_systems){Console.Write($"'{os}', ");}

Console.Write("\nOrdered oses: ");
foreach (var os in operating_systems.Order(string_comparer)){Console.Write($"'{os}', "); }

Console.WriteLine($"\n[C] COMBINE STRINGS\n");

string os_story = string.Join(" => ", operating_systems);
Console.WriteLine(os_story);

Console.WriteLine($"\n[D] FORMAT STRINGS\n");

string produce_nm = "2011 Honda CBR 250R";
decimal produce_px = 7999.99M;
DateTime today_dt = DateTime.Today;
// set culture!~!
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
Console.WriteLine($"{produce_nm} was bought for {produce_px:C} on {today_dt:dddd}");
// [D1] add product name
// [D2] add product price
// [D3] add todays date



Console.WriteLine($"\n[E] CHAR CHECKING\n");

Console.WriteLine($"char.IsDigit('a'): {char.IsDigit('a')} [exp: F]");
Console.WriteLine($"char.IsDigit('6'): {char.IsDigit('6')} [exp: T]");
Console.WriteLine($"char.IsLetter('6'): {char.IsLetter('6')} [exp: F]");
Console.WriteLine($"char.IsLetter('b'): {char.IsLetter('b')} [exp: T]");
Console.WriteLine($"char.IsLower('o'): {char.IsLower('k')} [exp: T]");
Console.WriteLine($"char.IsLower('P'): {char.IsLower('U')} [exp: F]");
Console.WriteLine($"char.IsUpper('M'): {char.IsUpper('N')} [exp: T]");
Console.WriteLine($"char.IsUpper('q'): {char.IsUpper('t')} [exp: F]");
Console.WriteLine($"char.IsSeparator(' '): {char.IsSeparator(' ')} [exp: T]");
Console.WriteLine($"char.IsSeparator('s'): {char.IsSeparator('s')} [exp: F]");

Console.WriteLine($"\n[E] VOWEL & STRING SEARCH\n");

string all_vowels = "aeiouAEIOU";
SearchValues<char> search_values_vowels_instance = SearchValues.Create(all_vowels);
ReadOnlySpan<char> text_to_be_searched = "messi";

int idx_of_first_vowel = text_to_be_searched.IndexOfAny(search_values_vowels_instance);
Console.WriteLine($"The first vowel in '{text_to_be_searched}' is at index: '{idx_of_first_vowel}'");


