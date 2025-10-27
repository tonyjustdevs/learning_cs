

namespace TP.SharedNamespace;

public partial class Person
{
    //public string GetOrigin()
    public string Origin_Prop
    { get 
        {
            return $"{Name} lives in {HomePlanet}";
        } 
    }
        
}


    // first property: GetOrigin method -  use property syntax working on all vers of C#.
    // second property: return a greeting message - use lambda expression body => syntax from C# 6+
    // third property: calculate - person’s age.
