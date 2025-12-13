using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NW.EntModels;

public class Prod1
{
    public int Prod1Id { get; set; } // required

    [Required] 
    [StringLength(40)]
    public string Prod1Name { get; set; } = null!; // lenght<40 & non-null?

    public string? Prod1Desc { get; set; }


    [Column("Price",TypeName = "money")]
    public double? Cost { get; set; }

    [Column("UnitsInStock")]
    public short? StockAmt { get; set; }
    public virtual Cat1 Cat1 { get; set; } = null!;
}
