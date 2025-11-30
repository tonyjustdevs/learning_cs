using System.Reflection;
using TP.SharedLibraries;

Console.WriteLine("Hello, CarApp3!");


// TODO: [program.cs]
/// --- instantiation --- ///
// Car3 car3=new(){Model=..., Year=...};
Car3 car3 = new() { CountryOfOrigin = "Japanese", Model = "Toyota Yaris", Year = 2005 };
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

