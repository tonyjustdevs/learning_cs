namespace TPSharedLib.EntityModels2;

public class Category2
{
	public int CategoryId { get; set; }
	public string CategoryName { get; set; } = null!;
	public string? Description { get; set; }

	// add Product2 Entity Class
	public virtual ICollection<Product2> Product2s { get; set; } = new HashSet<Product2>();
}

	//	"CategoryId" INTEGER PRIMARY KEY,
	//	"CategoryName" nvarchar(15) NOT NULL,
	//	"Description" "ntext" NULL ,