using Dumpify;
using Microsoft.EntityFrameworkCore; // To use Include method.
using Northwind.EntityModels;
using System.ComponentModel; // To use Northwind, Category, Product.
using System.Reflection.Metadata;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
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
    private static void LoadSingleCategoryQueryCatId4()
    {
        using (var db_context_instance = new NorthwindDb())
        {
            //var blog = await db_context_instance.Categories
            //    .SingleAsync(b => b.CategoryId== 4)     ;
            //var cat_ent_4_query = db_context_instance.Categories
            //    .Single(b => b.CategoryId == 4);
            var cat_ent_4_query = db_context_instance.Categories
                .Where(b => b.CategoryId == 4);

            WriteLine($"/ ------------------------------------ ");
            WriteLine($"{cat_ent_4_query.ToQueryString()}");
            WriteLine($"------------------------------------ /");

            //foreach (var item in cat_ent_4_query)
            //{
            //    WriteLine($"[pid {item.CategoryId}]:{item.CategoryName}");
                
            //}


            //WriteLine($"cat_ent_4_id: {cat_ent_4_query.CategoryId} [{cat_ent_4_query.CategoryId.GetType()}]");
            //WriteLine($"cat_ent_4_nm: {cat_ent_4_query.CategoryName} [{cat_ent_4_query.CategoryName.GetType()}]");
            //WriteLine($"cat_ent_4_ds: {cat_ent_4_query.Description} [{cat_ent_4_query.Description?.GetType()}]");
        }
    }
    private static void LoadSingleCategoryEntityCatId4()
    {
        using (var db_context_instance = new NorthwindDb())
        {
            //var blog = await db_context_instance.Categories
            //    .SingleAsync(b => b.CategoryId== 4)     ;
            //var cat_ent_4_query = db_context_instance.Categories
            //    .Single(b => b.CategoryId == 4);
            var cat_ent_4 = db_context_instance.Categories
                .Single(b => b.CategoryId == 4);

            WriteLine($"/ ------------------------------------ ");
            WriteLine($"{cat_ent_4.GetType()}");
            WriteLine($"------------------------------------ /");

            //foreach (var item in cat_ent_4_query)
            //{
            //    WriteLine($"[pid {item.CategoryId}]:{item.CategoryName}");

            //}


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

    private static void TxtbookQueryingProducts()
    {
        using NorthwindDb db = new();
        SectionTitle("Products that cost more than a price, highest at top");
        string? input;
        decimal price;
        do
        {
            Write("Enter a product price: ");
            input = ReadLine();
        } while (!decimal.TryParse(input, out price));
        IQueryable<Product>? products = db.Products?
          .Where(product => product.Cost > price)
          .OrderByDescending(product => product.Cost);
        if (products is null || !products.Any())
        {
            Fail("No products found.");
            return;
        }

        // Calling ToQueryString does not execute against the database.
        // LINQ to Entities just converts the LINQ query to an SQL statement.
        Info($"ToQueryString: {products.ToQueryString()}");

        foreach (Product p in products)
        {
            WriteLine(
              "{0}: {1} costs {2:$#,##0.00} and has {3} in stock.",
              p.ProductId, p.ProductName, p.Cost, p.Stock);
        }
    }

    private static void CategoriesByProduct()
    {
        using var db_context = new NorthwindDb();

        var cats_by_prods = db_context.Categories
            .Include(c => c.Products);
        
        WriteLine($"cats_by_prods.ToQueryString()\n: {cats_by_prods.ToQueryString()}\n\n");

        foreach (var item in cats_by_prods)
        {
            //WriteLine($"{item.CategoryId}: {item.CategoryName} {item.Products}");
            WriteLine($"{item.CategoryId}: {item.CategoryName}: ");
            foreach (var prod in item.Products)
            {
                WriteLine($"[pid: {prod.ProductId}]: {prod.ProductName}");
            }
            // cat_id1, catname:
            // - prod1
            // - prod2
            // ....
        }
    } //item.Dump(label: "Default output");
    private static void CategoriesByProductSummary()
    {
        using var db_context = new NorthwindDb();

        var cats_by_prods = db_context.Categories
            .Include(c => c.Products);

        WriteLine($"cats_by_prods.ToQueryString()\n: {cats_by_prods.ToQueryString()}\n\n");

        foreach (var item in cats_by_prods)
        {
            //WriteLine($"{item.CategoryId}: {item.CategoryName} {item.Products}");
            WriteLine($"[CatId {item.CategoryId}] {item.CategoryName} has {item.Products.Count} of Product(s)");
            // cat_id1, catname, '#' of prods
            // cat_id2, catname, '#' of prods
        }
    }

    private static void CategoriesByProductWithMinStockSummary(decimal min_stock=100)
    {
        using var db_context = new NorthwindDb();

        var query = db_context.Categories
            .Include(c => c.Products.Where(p =>p.Stock>min_stock));
            
        WriteLine($"/ ------------------------------------ ");
        WriteLine($"{query.ToQueryString()}");
        WriteLine($"------------------------------------ /");

        WriteLine($"\nProducts with a minimum of {min_stock} stock:\n");
        foreach (var item in query)
        {
            WriteLine($"[CatId {item.CategoryId}] {item.CategoryName} has {item.Products.Count} of Product(s)");
        }
    }

    private static void CategoriesByProductWithMinStockDetailed(decimal min_stock = 100)
    {
        using var db_context = new NorthwindDb();

        var query = db_context.Categories
            .Include(c => c.Products.Where(p => p.Stock > min_stock));

        WriteLine($"/ ------------------------------------ ");
        WriteLine($"{query.ToQueryString()}");
        WriteLine($"------------------------------------ /");

        WriteLine($"\nProducts with a minimum of {min_stock} stock:\n");
        foreach (var item in query)
        {
            WriteLine($"[CatId {item.CategoryId}] {item.CategoryName} has {item.Products.Count} of Product(s):");
            foreach (var prod in item.Products)
            {
                WriteLine($"- [Pid {prod.ProductId}]: {prod.ProductName} has minimum {prod.Stock} stock");
            }
        }
    }



    // end partial program
}