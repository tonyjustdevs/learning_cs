using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TPSharedLib.EntityModels;

public class Category
{
    public int CategoryID { get; set; }     // pkey
    public string CategoryName { get; set; } = null!;//
    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
}

//  from .sql
//  CREATE TABLE Categories (
//      CategoryId INTEGER       PRIMARY KEY,
//      CategoryName NVARCHAR(15) NOT NULL,
//      Description  "NTEXT",
//      Picture      "IMAGE"
//  );