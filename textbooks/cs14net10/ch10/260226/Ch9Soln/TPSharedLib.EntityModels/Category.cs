namespace TPSharedLib.EntityModels;

public class Category
{
    public string CategoryName { get; set; } = null!;
    public int CategoryId { get; set; }
    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
}

//	"CategoryId" INTEGER PRIMARY KEY,
//	"CategoryName" nvarchar(15) NOT NULL,
//	"Description" "ntext" NULL ,