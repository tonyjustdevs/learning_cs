

namespace TP.SharedNamespace;

public partial class Person
{
    public string Prop1_Origin // prop-1
    { get
        {
            return $"{Name} lives in {HomePlanet}";
        }
    }

    public string Prop2_Greeting => $"G'day, are you excited to me or is it your Species '{Species}'";
    public int Prop3_CalculatedAge => DateTime.Today.Year - Born.Year;

    private string? _favouritePrimaryColor1; // private backingfield
                                            // create property: gets & sets _favouritePrimaryColor
    public string? FavouritePrimaryColor1
    {
        get { return _favouritePrimaryColor1; }
        set {
            switch (value?.ToLower())
            {
                case "blue":
                case "red":
                case "green":
                    _favouritePrimaryColor1 = value;
                    break;
                default:
                    throw new ArgumentException($"{value} is awful." +
                        $" Choose from red, green or blue.");
            }
        }
    }
}


    // first property: GetOrigin method -  use property syntax working on all vers of C#.
    // second property: return a greeting message - use lambda expression body => syntax from C# 6+
    // third property: calculate - person’s age.
