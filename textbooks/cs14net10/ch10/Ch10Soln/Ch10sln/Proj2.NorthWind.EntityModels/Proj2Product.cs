using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj2.NorthWind.EntityModels;

public class Proj2Product
{
    [Required]
    public int Proj2ProductId { get; set; }
    [StringLength(40)]
    public string Proj2ProductName { get; set; } = null!;

    [Column("UnitPrice", TypeName ="money")]
    public decimal Cost { get; set; }
    
    [Column("UnitInStock")]
    public short Stock { get; set; }

    [Required]
    public int Proj2CategoryId { get; set; }

    [Required]
    public virtual Proj2Category Proj2Category { get; set; } = null!;

}
