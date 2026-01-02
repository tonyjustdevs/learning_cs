using System.Globalization;
using System.Text.RegularExpressions;
partial class Program
{
    // add static method
    public static void ConfigCulture()
    {

        var mate    = CultureInfo.CurrentCulture; //en - AU
        var getinfo = CultureInfo.GetCultureInfo("en-AU");

        if (mate.Name == getinfo.Name || mate.Equals(getinfo))
        {
            Console.WriteLine($"same data, but not nec same object: '{mate}' '{getinfo}'");
        } else
        {
            Console.WriteLine($"not same: '{mate}' '{getinfo}'");
        }

     

        Console.WriteLine("CurrentCulture: [" + mate + "] [rocket: 🚀]");
        Console.WriteLine("GetCultureInfo('en-AU'): " + getinfo + " [rocket: 🚀]");
        
        
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;

        
        //CultureInfo.CurrentCulture = new CultureInfo("en-US");
        getinfo = CultureInfo.GetCultureInfo("en-US");
        mate    = CultureInfo.CurrentCulture;
        
        
        Console.WriteLine("CurrentCulture: [" + mate + "] [rocket: 🚀]");
        Console.WriteLine("GetCultureInfo('en-US'): " + getinfo + " [rocket: 🚀]");


        //CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
    }
    // add culture class

}
