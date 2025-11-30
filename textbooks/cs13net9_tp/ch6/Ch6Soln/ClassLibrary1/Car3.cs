using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace TP.SharedLibraries;

public class Car3
{
    // TODO:
    public string? Model { get; set; }
    public int Year { get; set; }
    public string? CountryOfOrigin { get; set; }
    public bool IsJapanese()
    {
        if (CountryOfOrigin == "Japanese")
        {
            return true;
        }
        return false;
    }

    public void ShowCarInfo()
    {
        Console.WriteLine("\nYear: '{0}', IsJap: '{1}', Country: '{2}', Model: '{3}'.", 
            Year, IsJapanese(), CountryOfOrigin, Model);
    }

    public Car3 setModel(string model)
    {
        Model = model;
        return this;
    }
    public Car3 setCountry(string country)
    {
        CountryOfOrigin = country;
        return this;
    }
    public Car3 setYear(int year)
    {
        Year = year;
        return this;
    }

    // TODO: [program.cs]
    /// --- instantiation --- ///       [DONE]
    // Car3 car3=new(){Model=..., Year=...};

    /// --- properties --- ///          [DONE]
    // car3.Model=...
    // car3.Year=...

    /// --- static method --- ///       [DONE]
    // Car3.isJapanese() 

    /// --- extension method --- ///    [DONE]
    // car3.isJapanese()


    /// --- method chaining 1 --- ///   [WIP]
    // car.SetModel()
    // car.SetYear()

    /// --- method chaining 2 --- ///
    // car.SetModel.SetYear.()


}


public static class Car3Extension// create static & extension method 
{
    public static bool IsJapaneseStatic(Car3 car)
    {   // [Car3Ext-Test-1: Car3Extension.IsJapaneseStatic(car3)]
        if (car.CountryOfOrigin == "Japanese")
        {
            Console.WriteLine($"{car.Model} is Japanese! [via Car3Extension.IsJapaneseStatic(...)]");
            return true; 
        }
        Console.WriteLine($"{car.Model} is not Japanese! [via Car3Extension.IsJapaneseStatic(...)]");
        return false;
    }

    public static bool IsJapaneseMethExtension(this Car3 car)
    {   // [Car3Ext-Test-2: car.IsJapaneseMethExtension()]
        if (car.CountryOfOrigin == "Japanese")
        {
            Console.WriteLine($"{car.Model} is Japanese! [via car.IsJapaneseMethExtension()]");
            return true; 
        }
        Console.WriteLine($"{car.Model} is not Japanese! [via car.IsJapaneseMethExtension()]");
        return false;
    }

    public static Car3 SetModelViaExtension(this Car3 car, string model)
    {
        car.Model = model;
        return car;
    }

    public static Car3 SetYearViaExtension(this Car3 car, int year)
    {
        car.Year = year; return car;
    }

}