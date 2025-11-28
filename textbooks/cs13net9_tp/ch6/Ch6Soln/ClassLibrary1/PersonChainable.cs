
namespace TP.SharedLibraries;

public class PersonChainable
{

    // PersonChainable.cs
    public string? Name { get; set; }           // 1. add fld [Name]
    public int Age { get; set; }                // 2. add fld [Age]
    

    public PersonChainable SetName(string? name)
    {
        Name=name;
        return this;
    }
    public PersonChainable SetAge(int age)
    {
        Age = age;
        return this;
    }

    private string? _name2;
    public string? Name2  
    { 
        get => _name2;
        set
        {       // apply name validation
            if (value is null)
            {
                throw new ArgumentNullException("Trying to set Name2 to null!");

            }
            _name2 = value;
        }
    }           // 1. add fld [Name]

    //public void SetName2(string? Name)        // 3b. 'this.Name' is useful when parameter is 
    //{                                         //     also named 'Name' 
    //    this.Name = Name;
    //}

    // 3. add mth [SetName()]

    // 4. add mth [SetAge()]

    // Program.cs
    // 1. add PersonC instance
    // 2. run SetName()
    // 3. run SetAge()
}
