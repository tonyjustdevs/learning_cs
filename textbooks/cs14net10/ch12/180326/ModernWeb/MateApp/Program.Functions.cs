using Northwind.EntityModels;
partial class Program
{
    // create tightly coupled Product/Category Service with Database Context


}

public class ProductService
{ 
    public ProductService()
    {
        var db = new NorthwindContext();
        var products = db.Products;
    }
}

public class CategoryService1
{
    public CategoryService1()
    {
    }

    public void GetCatNames()
    {
        using var db = new NorthwindContext();
        var categories = db.Categories;
        
        WriteLine("\nCatNames:");
        foreach (var item in categories)
        {
            WriteLine($"- {item.CategoryName}");
        }
    }
}

public class CategoryService2
{
    private readonly NorthwindContext _db;

    public CategoryService2(NorthwindContext db)
    {
        _db = db;
    }

    public void GetNames()
    {
        //using var db = new NorthwindContext();
        var items = _db.Categories;

        WriteLine("\nCatNames2:");
        foreach (var item in items)
        {
            WriteLine($"- {item.CategoryName}");
        }
    }
}


public class ProductService2
{
    private readonly NorthwindContext _db;

    public ProductService2(NorthwindContext db)
    {
        _db = db;
    }

    public void GetNames()
    {
        //using var db = new NorthwindContext();
        var items = _db.Products.Take(10);

        WriteLine("\nProdNames2:");

        foreach (var item in items)
        {
            WriteLine($"- {item.ProductName}");
        }
    }
}

public class ServiceFactoryNWContext
{
    public ServiceFactoryNWContext() { }
    public ProductService2 CreateProductService()
    {
        return new ProductService2(new NorthwindContext());
    }
    public CategoryService2 CreateCategoryService()
    {
        return new CategoryService2(new NorthwindContext());
    }
}

public class ServiceFactoryNWContext2
{
    private NorthwindContext _db = new();
    public ServiceFactoryNWContext2() { }
    public ProductService2 CreateProductService()
    {
        return new ProductService2(_db);
    }
    public CategoryService2 CreateCategoryService()
    {
        return new CategoryService2(_db);
    }
}

public class ServiceFactoryNWContext3
{
    //private NorthwindContext _db = new();
    public static NorthwindContext CreateNorthwindContext() => new();
    //public static ServiceFactoryNWContext3() { }
    public static ProductService2 CreateProductService()
    {
        return new ProductService2(CreateNorthwindContext());
    }
    public static CategoryService2 CreateCategoryService()
    {
        return new CategoryService2(CreateNorthwindContext());
    }
}

public class ServiceFactoryNWContext4
{
    //private NorthwindContext _db = new();
    public static NorthwindContext CreateNorthwindContext() => new();
    //public static ServiceFactoryNWContext3() { }
    public static ProductService2 CreateProductService() => new ProductService2(CreateNorthwindContext());
    public static CategoryService2 CreateCategoryService() => new CategoryService2(CreateNorthwindContext());
}


