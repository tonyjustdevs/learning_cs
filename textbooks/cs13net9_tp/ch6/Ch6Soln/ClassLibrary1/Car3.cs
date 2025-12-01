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
        if (CountryOfOrigin == "Japan")
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
        if (car.CountryOfOrigin == "Japan")
        {
            Console.WriteLine($"{car.Model} is Japanese! [via Car3Extension.IsJapaneseStatic(...)]");
            return true; 
        }
        Console.WriteLine($"{car.Model} is not Japanese! [via Car3Extension.IsJapaneseStatic(...)]");
        return false;
    }

    public static bool IsJapaneseMethExtension(this Car3 car)
    {   // [Car3Ext-Test-2: car.IsJapaneseMethExtension()]
        if (car.CountryOfOrigin == "Japan")
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

    public static Car3 SetYearViaExtension(
        this Car3 car, int year)
    {
        car.Year = year; return car;
    }

    // use [ExtensionBlocks]:
    //  - extension_methods
    //  - extension_members

    extension(Car3 car)
    {
        internal Car3 SetModel_INTERNALCar3_Via_ExtensionBlock(string model)
        {
            car.Model = model;
            return car;
        }
        internal Car3 SetYear_INTERNALCar3_Via_ExtensionBlock(int year)
        {
            car.Year = year;
            return car;
        }
        internal Car3 SetCountry_INTERNALCar3_Via_ExtensionBlock(string country)
        {
            car.CountryOfOrigin = country;
            return car;
        }

        internal bool IsJap_INTERNALCar3_Via_ExtensionBlock()
        {
            if (car.CountryOfOrigin=="Japan")
            {
                return true;
            }
            return false;
        }

    }

}


public static class Car3_ExtensionBlocks
{
    extension(Car3 car)
    {
        public Car3 External_SetModel_Via_ExtensionBlock(string model)
        {
            car.Model = model;
            return car;
        }
        public Car3 External_SetYear_Via_ExtensionBlock(int year)
        {
            car.Year = year;
            return car;
        }
        public Car3 External_SetCountry_Via_ExtensionBlock(string country)
        {
            car.CountryOfOrigin = country;
            return car;
        }

        public bool External_IsJap_Via_ExtensionBlock()
        {
            if (car.CountryOfOrigin == "Japan")
            {
                Console.WriteLine($"{car.Model} is Japanese! [via car.External_IsJap_Via_ExtensionBlock()]");
                return true;
            }
            Console.WriteLine($"{car.Model} is NOT Japanese! [via car.External_IsJap_Via_ExtensionBlock()]");
            return false;
        }
    }
}


public static class CarExt
{
    // 1. extend static method: Car.some_method();
    public static bool CarExt_IsAmerican(Car3 car3)
    {
        if (car3.CountryOfOrigin == "USA")
        {
            Console.WriteLine("I'm murican!");
            return true;
        }
        ;
        Console.WriteLine("I'm not murican!");
        return false;
    }
    // 2. extend instce method: car.some_method();
}


public static class CarExt2 
{ 
    public static bool IsVeryOldStatic(Car3 car3)
    {
        if (car3.Year<2000)
        {
            Console.WriteLine("This car is Ancient! (<2000) [IsVeryOldStatic()]");
            return true;
        }
        Console.WriteLine("This car is a Gen-Z! (>=2000) [IsVeryOldStatic()]");
        return false;
    }

    public static bool IsVeryOldInstce(this Car3 car3)
    {
        if (car3.Year < 2000)
        {
            Console.WriteLine("This car is Ancient! (<2000) [IsVeryOldInstce()]");
            return true;
        }
        Console.WriteLine("This car is a Gen-Z! (>=2000) [IsVeryOldInstce()]");
        return false;
    }

}


public static class CarExt3ViaExtensionBlocks
{
    extension(Car3 car3)
    {
        public bool IsVeryOldInstceViaExtensionBlocks(int year)
        {
            if (car3.Year < year)
            {
                Console.WriteLine($"This car is Ancient! (<{year}) [CarExt3ViaExtensionBlocks.IsVeryOldInstceViaExtensionBlocks()]");
                return true;
            }
            Console.WriteLine($"This car is a Gen-Z! (>={year}) [CarExt3ViaExtensionBlocks.IsVeryOldInstceViaExtensionBlocks()]");
            return false;
        }
        public bool IsVeryOldInstceViaExtensionBlocks()
        {
            int year = 2000;
            if (car3.Year < year)
            {
                Console.WriteLine($"This car is Ancient! (<{year}) [CarExt3ViaExtensionBlocks.IsVeryOldInstceViaExtensionBlocks()]");
                return true;
            }
            Console.WriteLine($"This car is a Gen-Z! (>={year}) [CarExt3ViaExtensionBlocks.IsVeryOldInstceViaExtensionBlocks()]");
            return false;
        }
    }
}