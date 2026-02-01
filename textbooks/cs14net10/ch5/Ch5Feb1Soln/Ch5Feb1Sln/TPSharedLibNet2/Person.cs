namespace TPNS.TPSharedLibNet2
{
    public class Person
    {
        public string?              Name;
        public DateTimeOffset       Born;
        public EnumCountrys         CountryFrom;
        public EnumByteCountrys     CountryVisited;
        public const string         Species = "Homo Sapien";    // compile-time
        public readonly string      HomePlanet = "Earth";       // instance read-only run-time field

        private string              secretcode = "mate";
        public string?              stringprop { get; } = "cunt";

        #region Constructors: called when using new instantiate a type
        
        private readonly DateTime _Instantiated;
        public Person()
        {
            Name = "Unknown";
            _Instantiated = DateTime.Now;
        }
        #endregion
    }
}
