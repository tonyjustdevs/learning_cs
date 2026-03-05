using System.ComponentModel.DataAnnotations;

namespace Northwind.EntityModels;

public class Category 
{
    public int CategoryId { get; set; }
    [StringLength(15)]
    public string CategoryName { get; set; } = null!;
    public string? Description { get; set; }
    public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
}

//CREATE TABLE Categories(
//    CategoryId INTEGER       PRIMARY KEY,
//    CategoryName NVARCHAR (15) NOT NULL,
//    Description  NTEXT NULL,
//);
