namespace TPLibraryProject;

public class Person
{
    public string? Name { get; set; } // fields 1
    public DateTime? Dob { get; set; } // fields 2
    public SightsOfSydney? FavPlace {get;set;}
    public SightsOfSydneyList? FavPlaceList {get;set;}

    // constructor 1: default constructor
    public Person() { }

    // constructor 1: custom constructor
    public Person(string? name_param, DateTime? dob_param, 
        SightsOfSydney? favplace_param,
        SightsOfSydneyList? favplacelist_param = null)
    {
        Name = name_param;
        Dob = dob_param;
        FavPlace = favplace_param;
        FavPlaceList = favplacelist_param;
    }
}

