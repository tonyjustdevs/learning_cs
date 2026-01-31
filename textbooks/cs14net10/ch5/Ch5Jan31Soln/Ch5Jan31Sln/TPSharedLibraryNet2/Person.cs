namespace TPNS.TPSharedLibraryNet2;

public class Person : object
{
    #region Field member: Data or state of this person

    public string?              Name; //? can be null
    public DateTimeOffset       Born;
    public EnumPopSports        SportFavourite;
    public EnumBytePopSports    SportsHated;

    #endregion
}

