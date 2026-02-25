using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace TPSharedLib.EntityModels;

public class Product
{
    public int ProductId { get; set; } //	"ProductId" INTEGER PRIMARY KEY,
    [Required]    
    [StringLength(40)] // "ProductName" nvarchar(40) NOT 
    public string ProductName { get; set; } = null!;

    [Column("UnitPrice",TypeName="money")]    //	"UnitPrice" "money" 
    public decimal Cost { get; set; }

    [Column("UnitsInStock",TypeName="smallint")]    //	"UnitsInStock" "smallint" 
    public short? Stock { get; set; }

    public bool Discontinued { get; set; }

    // references to other ents (classes)
    public int CategoryId { get; set; }
    public Category Category { get; set; } = new();

}

