namespace TPNS.TPSharedLibNet2;
public partial class Person
{
    #region Properties
    public string PropGetOrigin { get => string.Format($"{Name} is from {HomePlanet}");}
    public string PropGreeting{ get => string.Format($"Gday, I'm {Name}");}
    public int PropGetAge{ get => DateTime.UtcNow.Year-Dob.Year;}

    public EnumByteSports PropSportsTop
    {
        get { return field; }
        set // exception for commas 
        {
            if (value.ToString().Contains(","))
            {
                throw new ArgumentException($"Cannot have more than 1 Top Sports: {value}", nameof(PropSportsTop));
            }
            
            if (!Enum.IsDefined(typeof(EnumByteSports), value))
            {
                throw new ArgumentException($"Must choose a valid sport: {value}", nameof(PropSportsTop));
            }
            field = value;
        }
    }
            

    #endregion
}
