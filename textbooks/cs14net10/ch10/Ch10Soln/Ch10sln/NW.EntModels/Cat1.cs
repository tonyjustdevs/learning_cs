
namespace NW.EntModels;

public class Cat1
{
    public int Cat1Id { get; set; }
    public string Cat1Name { get; set; } = null!; // cant be null
    public string? Cat1Desc { get; set; }
    public virtual ICollection<Prod1> Product { get; set; } = new HashSet<Prod1>();

}
