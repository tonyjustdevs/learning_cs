
namespace TPNS.TPSharedModernLib;

public record ImmutableAnimals(string Name, string Species) 
{
    public override string ToString()
    {
        return $"I'm {Name} & I'm a {Species}";
    }
};
