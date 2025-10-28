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
    private string? _favSport;
    public string? FavSport
    {
        get
        {
            return _favSport;
        }
        set
        {
            //_favSport = value;
            //Console.WriteLine($"\n{value?.ToLower()} was your chosen sport!...\n");
            switch (value?.ToLower())
            {
                case "football":
                case "tennis":
                    _favSport = value;
                    break;
                case "pickleball":
                    throw new ArgumentException($"{value} is for losers!");
                default:
                    throw new ArgumentException($"{value} is a not a cool sport.");
            }
        }
    }

    // create favourite food
    // 1. add [pri] (.BackingField): _favFood_BField
    // 2. add [pub] (.Property) {get}: FavFood_Prop
    // 3. add [pub] (.Property) {set}: _favFood_BField=value
    // 3. add [pub] (.Property) {set}: custome logic

    private string? _favFood_backingfield;
    public string? FavFood_property
    { 
        get 
        {
            return _favFood_backingfield;
        }
        set 
        {
            Console.WriteLine($"\n{value?.ToUpper()} was chosen...\n");
            switch (value?.ToUpper())
            {
                case "PIZZA":
                case "PHO":
                    Console.WriteLine($"\n{value?.ToUpper()} is a great choice!!! \n");
                    _favFood_backingfield = value;
                    break;
                default:
                    throw new ArgumentException($"{value?.ToUpper()} is not tasty!");
            }
            _favFood_backingfield = value;
        }
    }
    // 1. create [private] [._bakingField] :   ._favCities
    // 2. create [public]  [.Property]{get}:   .FavCities
    // 3. create [public]  [.Property]{set}:   ._favCities=value

    private string? _favCities;
    public string? FavCities
    {
        get { 
            return _favCities; 
        }
        set {
            Console.WriteLine($"{value} chosen!");
            switch (value?.ToLower())
            {
                case "da nang":
                    Console.WriteLine($"amazing, '{value}' is beachy vibe of vietnam!");
                    _favCities = value;
                    break;
                case "kl":
                    Console.WriteLine($"yum '{value}' has laksa and all that good food!!");
                    _favCities = value;
                    break;
                case "saigon":
                    Console.WriteLine($"great choice of '{value}', the sleepy that never sleeps!!");
                    _favCities = value;
                    break;
                case "sydney":
                    Console.WriteLine($"'{value}'? are you rich or something?");
                    break;
                default:
                    throw new ArgumentException($"You chose {value}, do you not have standards, try again!!");
            }
        }

    }
    //CountryEnumByte 
    //private CountryEnum? _country2;
    private CountryEnumByte? _country2;
    //public CountryEnum? Country2 { 
    public CountryEnumByte? Country2 { 
        get 
        {
            return _country2;
        }
        set {
            string cty = value.ToString();
            Console.WriteLine($"value.ToString(): {cty}");
            Console.WriteLine($"typeof(CountryEnum): {typeof(CountryEnumByte)}"); //TP.SharedNamespace.CountryEnum
            bool EnumTF = Enum.IsDefined(typeof(CountryEnumByte), value);
            Console.WriteLine($"Checking whether input Country '{value}' is Type 'Enum': {EnumTF}");

            if (!EnumTF) {
                throw new ArgumentException($"You dont have the relevant visa to go to: '{value}'");
            }
            _country2 = value;
        }
    }
}

