using TP.SharedNamespace;

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
Console.Write($"{kiddos_str}]");
//  - .select ... LINQ
//  - .JOIN ??



