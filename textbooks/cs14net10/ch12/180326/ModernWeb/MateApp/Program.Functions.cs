using Microsoft.EntityFrameworkCore;
using Northwind.EntityModels;

partial class Program
{
    private static void GetCategoriesId1()
    {
        using var db = new NorthwindContext();
        foreach (var category in db.Categories)
        {
            WriteLine($"{category.CategoryId}, {category.CategoryName}");
        }
    }
    private static void GetCategoriesId2()
    {
        //using var db = new NorthwindContext();    // v1
        using var db = NorthwindContext.Create();   // v2
        foreach (var category in db.Categories)
        {
            WriteLine($"{category.CategoryId}, {category.CategoryName}");
        }
    }
    private static void GetCategoriesId3()
    {
        //using var db = new NorthwindContext();    // v1
        //using var db = NorthwindContext.Create();   // v2
        var db = DbFactory.CreateNorthwindContext();
        foreach (var category in db.Categories)
        {
            WriteLine($"{category.CategoryId}, {category.CategoryName}");
        }
    }

    private static void GetCategoriesId4_DI(NorthwindContext db) // v4 inject it
    {
        //using var db = new NorthwindContext();            // v1
        //using var db = NorthwindContext.Create();         // v2
        //var db = DbFactory.CreateNorthwindContext();      // v3
        //var db = DbFactory.CreateNorthwindSQLiteContext();
        foreach (var category in db.Categories)
        {
            WriteLine($"{category.CategoryId}, {category.CategoryName}");
        }
    }

}

public class ProductService
{
    // create a field/property for db for the Product Service
    private NorthwindContext? _DBContext;
    public ProductService() { }

    public ProductService(NorthwindContext dbcontext)
    {
        _DBContext = dbcontext;
    }
}
