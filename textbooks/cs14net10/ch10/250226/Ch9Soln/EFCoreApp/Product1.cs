
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPSharedLib.EntityModels;

public class Product1
{
    public int ProductId {get;set;}

    [Required]
    [StringLength(40)]
    public string ProductName { get; set; } = null!;
    
    [Column("UnitPrice",TypeName = "money")]
    public decimal? Cost {get;set;}
    
    [Column("UnitsInStock", TypeName = "smallint")]
    public short? Stock {get;set;}


    public bool Discontinued {get;set;}
    
    public int CategoryId {get;set;}
    public virtual Category Category { get; set; } = null! ;
}


	//"ProductId" INTEGER PRIMARY KEY,
	//"ProductName" nvarchar(40) NOT NULL,
	//"UnitPrice" "money" NULL CONSTRAINT "DF_Products_UnitPrice" DEFAULT(0),
	//"UnitsInStock" "smallint" NULL CONSTRAINT "DF_Products_UnitsInStock" DEFAULT(0),
	//"Discontinued" "bit" NOT NULL CONSTRAINT "DF_Products_Discontinued" DEFAULT(0),
	//"CategoryId" "int" NULL ,
	//"Category"
