using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Northwind.EntityModels;

public class Product
{
    public int ProductId { get; set; }              //    ProductId INTEGER       PRIMARY KEY,

    [StringLength(40)]
    public string ProductName { get; set; } = null!;//    ProductName     NVARCHAR(40) NOT NULL,
    
    [Column("UnitPrice",TypeName = "money")]
    public decimal? Cost { get; set; }              //    UnitPrice MONEY         NULL
    
    [Column("UnitsInStock")]
    public short? Stock { get; set; }               //    UnitsInStock SMALLINT      NULL

    public bool Discontinued { get; set; }          //    Discontinued BIT           NOT NULL
    public int CategoryId { get; set; }             //    CategoryId      INT NULL,
    public virtual Category Category { get; set; } = null!;          //
}
//    CONSTRAINT FK_Products_Categories FOREIGN KEY(
//        CategoryId
//    )