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

        #region Constructors: called when using new instantiate a type

        public readonly DateTime Instantiated;
        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }
        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        #endregion
    }
}
