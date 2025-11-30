using TP.SharedLibraries;

Console.WriteLine("Hello, CarApp3!");


// TODO: [program.cs]
/// --- instantiation --- ///
// Car3 car3=new(){Model=..., Year=...};
Car3 car3 = new() { CountryOfOrigin = "Japan", Model = "Toyota Yaris", Year = 2005 };
car3.ShowCarInfo();
Car3Extension.IsJapaneseStatic(car3);           // [Car3Ext-Test-1] /// --- static method --- ///
car3.IsJapaneseMethExtension();                 // [Car3Ext-Test-2] /// --- extension method --- ///

/// --- properties --- ///
car3.Model = "Mitsubishi Lancer IX";
car3.Year = 2002;
car3.ShowCarInfo();
Car3Extension.IsJapaneseStatic(car3);           // [Car3Ext-Test-1] /// --- static method --- ///
car3.IsJapaneseMethExtension();                 // [Car3Ext-Test-2] /// --- extension method --- ///

/// --- method chaining 1 --- ///
car3.setModel("Vespa 946 Christian Dior")
    .setCountry("Italy")
    .setYear(2021);
car3.ShowCarInfo();
Car3Extension.IsJapaneseStatic(car3);           // [Car3Ext-Test-1] /// --- static method --- ///
car3.IsJapaneseMethExtension();                 // [Car3Ext-Test-2] /// --- extension method --- ///
/// --- method chaining 2 via extension --- ///

car3.SetModelViaExtension("Aprilia SRV 850 ABS/ATC")
    .SetYearViaExtension(2016);
car3.ShowCarInfo();
Car3Extension.IsJapaneseStatic(car3);           // [Car3Ext-Test-1] /// --- static method --- ///
car3.IsJapaneseMethExtension();                 // [Car3Ext-Test-2] /// --- extension method --- ///
Console.WriteLine();

Console.WriteLine("IEnumerable member extensions.....\n");
List<int> list = [1, 2, 3, 4, 5];
IEnumerable<int> large = list.WhereGreaterThan(3);
if (large.IsEmpty)
{
    Console.WriteLine("No large numbers.");
}
else
{
    Console.WriteLine("Found large numbers.");
}


//IEnumerable<int> numbers = [1, 2, 3];
//var big = numbers.WhereGreaterThan(2); // works!
//bool empty = numbers.IsEmpty;          // works!
// [Car3Ext-Test-3]: Internal Extension (pointless??)


// [Car3Ext-Test-4] : External Extension (cannot change source code of original class)
//  [Car3Ext-Test-4a]: add instance 
Car3 yamaha_bike = new();
yamaha_bike.ShowCarInfo();
//  [Car3Ext-Test-4b]: set fields via [external] extended_methods()
yamaha_bike.External_SetModel_Via_ExtensionBlock("Yamaha MT-07")
    .External_SetCountry_Via_ExtensionBlock("Japan")
    .External_SetYear_Via_ExtensionBlock(2025);
yamaha_bike.ShowCarInfo();
yamaha_bike.External_IsJap_Via_ExtensionBlock();


//  [Car3Ext-Test-4c]: get fields via [external] extended_fields()
