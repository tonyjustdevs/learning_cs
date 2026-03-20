using Microsoft.EntityFrameworkCore;
using Northwind.EntityModels;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

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
        //var db = DbFactory.CreateNorthwindContext();
        //foreach (var category in db.Categories)
        //{
        //    WriteLine($"{category.CategoryId}, {category.CategoryName}");
        //}
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


    // [1.] create a NORMAL method

    private static void NormalFuckenMethod(string? stupidmsg)
    {
        Console.WriteLine($"{stupidmsg}");
    }

    // [2.] create a GENERIC method
   
    private static void GenericFkenMethod<T>()  
    {
        Console.WriteLine($"I'm a generic fken method operating on T: {typeof(T)}");
    }

}

public class ProductService
{
    /// <summary>
    /// Holds the instance of the Northwind database context used by the ProductService.    
    /// </summary>

    /// <remarks>
    /// This field '_DBContext' stores a single instance of NorthwindContext
    /// This field '_DBContext' is injected from external sources as a parameter into this class 'ProductService'
    /// All instance methods use this injected 'context' to interact with database,
    /// ensuring consistent data access and improved performance compared to creating a new context for each operation.
    /// 
    /// </remarks>
    /// 
    private NorthwindContext? _DBContext;

    public ProductService() { }

    public ProductService(NorthwindContext dbcontext)
    {
        _DBContext = dbcontext;
    }

    public void GetAllCats()
    {
        //var categories = this._DBContext?.Categories ?? null ;
        var categories = this._DBContext?.Categories;
        if (categories is null) 
        {
            WriteLine("no cats found!");
            return;
        }
        WriteLine("\nAll Categories:");
        foreach (var item in categories)
        {
            WriteLine($"- {item.CategoryName}");

        }
    }
}

public class OrderService
{
    private readonly NorthwindContext _db = null!;
    public OrderService(NorthwindContext db)
    {
        _db = db;
    }

    public void GetRecentAllOrders()
    {
        var orders = this._db.Orders.OrderByDescending(o => o.Freight).Take(10);
        WriteLine("\nTop 10 Orders by Freight Costs: ");
        foreach (var order in orders)
        {
            WriteLine($"- {order.ShipName}: {order.Freight?.ToString("C")}");
            
        }
    }
}

public class ProductService2
{
    // lets keep db as a field 
    private NorthwindContext _db = null!;

    public ProductService2()
    {
    }

    public ProductService2 AddDBContext(NorthwindContext db)
    {
        this._db = db;
        return this;
    }
}

public class ServiceContainer
    {   // create a dictionary with type: <typeof(T), method_instructions>
        //public static Dictionary<typeof(NorthwindContext),>

    //some_dict[typeof(NorthwindDB)] => how to create db
    //Dictionary<Type,>
    //
    // create method to create db

        Dictionary<string,string> InstructionsDict = new();
        // given a type return method_instructions()??
        public static void GetTypeHowToCreateANwContext()
        {   // ServiceContainer.GetTypeHowToCreateANwContext
            //var db = new NorthwindContext();
            Func<NorthwindContext> HowToCreateANwContext = () => new NorthwindContext();

            WriteLine($"HowToCreateANwContext() is of type {HowToCreateANwContext.GetType()}");
            WriteLine($"HowToCreateANwContext() is of type {typeof(Func<NorthwindContext>)}");
            WriteLine($"typeof(Northwind) is of type {typeof(NorthwindContext)}");
            //System.Func`1[Northwind.EntityModels.NorthwindContext]
        }
            // some_dict[key,metho]
        public static Dictionary<Type, Func<object>> InstructionsDict2(Type type, Object someobj) 
        {
            var somedict = new Dictionary<Type, Func<object>>();
            return somedict;
        }

    // create a class that has a variable of dict
    // the variable is a dictionary
    // - set [k,v]  via dict[key]=value
    // - get [v]    via [k] on dict[key]
    //ServiceCont.
}



class SimpleContainer
{
    Dictionary<Type, Func<object>> map = new();

    public void Register<T>(Func<T> factory) 
    {  
        map[typeof(T)] = factory;
    }
        // q: what is Func<T>?
        // a: it is a generic method that operates on generic type 'T'
        // a: it is the body of a method, not the running of it

        // goal of Registion(): create a key-value pair map_dict:
        // - map[typeof(T) = factory]
        // container.Register<NorthwindContext>(()=> new NorthwindDB());

    //public T Resolve<T>() { ... }
}