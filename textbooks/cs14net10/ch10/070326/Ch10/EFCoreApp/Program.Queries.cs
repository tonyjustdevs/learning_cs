using Microsoft.EntityFrameworkCore; // To use Include method.
using Northwind.EntityModels;
using System.ComponentModel; // To use Northwind, Category, Product.
partial class Program
{
    private static void QueryingCategories()
    {
        using NorthwindDb db = new();
        SectionTitle("Categories and how many products they have");
        // A query to get all categories and their related products.
        // This is a query definition. Nothing has executed against the database.
        IQueryable<Category>? categories = db.Categories?
          .Include(c => c.Products);
        // You could call any of the following LINQ methods and nothing will be executed against the database:
        // Where, GroupBy, Select, SelectMany, OfType, OrderBy, ThenBy, Join, GroupJoin, Take, Skip, Reverse.
        // Usually, methods that return IEnumerable or IQueryable support deferred execution.
        // Usually, methods that return a single value do not support deferred execution.
        if (categories is null || !categories.Any())
        {
            Fail("No categories found.");
            return;
        }
        // Enumerating the query converts it to SQL and executes it against the database.
        // Execute query and enumerate results.
        foreach (Category c in categories)
        {
            //WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
            WriteLine($"{c.CategoryName} has {c.Products} products.");
        }
    }
    // id   CatName     Desc    Products
     //1	Beverages	Soft... Dict<Product>{"Product"}
    private static void LoadSingleCategoryEntityCatId4()
    {
        using (var db_context_instance = new NorthwindDb())
        {
            //var blog = await db_context_instance.Categories
            //    .SingleAsync(b => b.CategoryId== 4)     ;
            var cat_ent_4 = db_context_instance.Categories
                .Single(b => b.CategoryId == 4);
            WriteLine($"cat_ent_4_id: {cat_ent_4.CategoryId} [{cat_ent_4.CategoryId.GetType()}]");
            WriteLine($"cat_ent_4_nm: {cat_ent_4.CategoryName} [{cat_ent_4.CategoryName.GetType()}]");
            WriteLine($"cat_ent_4_ds: {cat_ent_4.Description} [{cat_ent_4.Description?.GetType()}]");
        }
    }

    private static void LoadAllDataCat()
    {
        using (var db_context = new NorthwindDb())
        {
            List<Category>? categories_all = db_context.Categories.ToList();
            WriteLine("Loading All Categories:");
            foreach (var item in categories_all)
            {
                WriteLine($"- {item.CategoryId}: {item.CategoryName}");
                
            }
        }
    }
    
    private static void FilterSweetCategories()
    {
        using var db_context = new NorthwindDb();

        IQueryable<Category> sweets = db_context.Categories.
            Where(c => c.Description == null||
            c.Description.ToLower().Contains("sweet"));

        WriteLine("sweet stuff: ");

        foreach (var item in sweets)
        {
            WriteLine($"{item.CategoryName}: {item.Description}");
        }
    }

    private static void GetProductsOverPx(decimal price_limit=100)
    {
        using (var db_context = new NorthwindDb()){
            var prods_under_px = db_context.Products.Where(p => p.Cost > price_limit).
                OrderByDescending(p=>p.Cost);
            int i=1;
            if (prods_under_px is null || !prods_under_px.Any())
            {
                WriteLine($"No products over {price_limit}.");
                return;
            }
            foreach (var item in prods_under_px)
            {
                WriteLine($"[{i}] {item.ProductName}: {item.Cost}");
                i++;
            }
        }
    }
    private static void GetProductsOverPxUserInput()
    {
        using (var db_context = new NorthwindDb())
        {
            string? user_input_str;
            decimal price_limit;
            int i;
            do
            {
                WriteLine($"Type in max price: ");
                user_input_str = Console.ReadLine();
                // do-whiel: leave while loop if we successfully tryparse, and turn into false to continue code
            } while (!decimal.TryParse(user_input_str, out price_limit)); 
            
            var prods_under_px = db_context.Products.Where(p => p.Cost > price_limit).
                OrderByDescending(p => p.Cost);

            i = 1;
            if (prods_under_px is null || !prods_under_px.Any())
            {
                WriteLine($"No products over {price_limit}.");
                return;
            }
            foreach (var item in prods_under_px)
            {
                WriteLine($"- [{item.ProductId}] {item.ProductName}: {item.Cost}");
                i++;
            }

            WriteLine("Products List Completed.\n");
        }

        WriteLine("DB Context Ended.");
    }

}