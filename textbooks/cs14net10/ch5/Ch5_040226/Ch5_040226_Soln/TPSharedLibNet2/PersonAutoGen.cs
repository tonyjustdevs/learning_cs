using System.Xml.Linq;

namespace TPNS.TPSharedLibNet2;

public partial class Person
{
    #region Properties: Methods to get and/or set data or state.
    public string PropertyOrigin
    {
        get
        {
            return string.Format($"{0} is from {1}.", Name,HomePlanet);
        }
    }
    
    public string PropertyGreetingText
    {
        get => $"Xin Chao, I'm {Name}. ";
    }

    public int PropertyAge
    {
        get => DateTime.Now.Year-Born.Year;
    }

    private EnumByteSports _sportsByteFav;
    public EnumByteSports SportsByteFav
    { 
        get => _sportsByteFav;
        set 
        {
            Console.WriteLine($"inputSportsName: {value}");
            string? inputSportsName = value.ToString();
            // validation 1: no commas
            if (inputSportsName.Contains(","))
            {
                throw new ArgumentException(
                    message:"Favourite Sport can only have a single enum value.",
                    paramName: nameof(SportsByteFav));
            }
            // validation 2: valid colour
            if (!Enum.IsDefined(typeof(EnumByteSports), value))
            {
                throw new ArgumentException(
                    message: $"{value} is an invalid sport, it is not a member of EnumSports enum",
                    paramName: nameof(value));
            }
            _sportsByteFav = value;
        }
    }
   


    #endregion
    #region Settable Properties
    public string? FavouriteIcecream{get;set;}
    #endregion

    #region PrivateBackingFields
    private string? _favouriteColour;
    public string? FavouriteColour
    {
        get
        {
            return _favouriteColour;
        }
        set
        {
            switch (value?.ToLowerInvariant())
            {
                case "green":
                case "red":
                case "blue":
                    _favouriteColour = value;
                    break;
                default:
                    throw new ArgumentException(
                        $"{value} is not a primary colour. Choose from green, red or blue.");
            }
        }
    }
    #endregion

}
