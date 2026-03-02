using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace TPSharedLib.EntityModels2;

public class Product2
{
    public int Product2Id { get; set; } // "ProductId" INTEGER PRIMARY KEY,

    [StringLength(40)] //"ProductName" nvarchar(40) NOT NULL,
    public string Product2Name { get; set; } = null!;

    [Column("UnitPrice",TypeName ="money")] // "UnitPrice" "money" 
    public decimal Cost { get; set; }

    [Column("UnitStock")] // "UnitsInStock" "smallint"
    public short? Stock{ get; set; }

    public bool Discontinued { get; set; } // "Discontinued" "bit"

    public int Category2Id { get; set; }
    public virtual Category2 Category2 { get; set; } = null!;

}

//	"CategoryId" "int" NULL ,
