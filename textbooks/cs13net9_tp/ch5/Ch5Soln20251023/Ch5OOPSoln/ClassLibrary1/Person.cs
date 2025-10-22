namespace TPSharedNamespace;

public class Person
{
    public string? Name { get; set; }
    public DateTime? DOB { get; set; }
    public SydneySuburbs? FavSuburb{ get; set; }
    public SydneySuburbsListBytes FavSuburbs { get; set; }
    public Person() { } // default constructor
    
    public Person(
        string name_param, 
        DateTime dob_param, 
        SydneySuburbs favsuburb_param,
        SydneySuburbsListBytes favsuburbs_param) 
    {
        Name        = name_param;
        DOB         = dob_param;
        FavSuburb   = favsuburb_param;
        FavSuburbs  = favsuburbs_param;
    }

}
