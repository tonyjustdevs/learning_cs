
namespace Proj2.NorthWind.EntityModels;

public class Proj2Category
{
    public int Proj2CategoryId { get; set; }
    public string Proj2CategoryName { get; set; } = null!;
    public string? Proj2CategoryDesc { get; set; }

    public virtual ICollection<Proj2Product> Proj2Product { get; set; }=new HashSet<Proj2Product>();

}
