using Dumpify;
using Microsoft.EntityFrameworkCore; // To use Include method.
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Northwind.EntityModels;
using System;
using System.ComponentModel; // To use Northwind, Category, Product.
using System.Net.Quic;
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

    private static void GetEagerTriggeredLoading(bool eager_bool=true)
    {
        using var db_context = new NorthwindDb();
        //DbSet<Product> query;
        List<Category> cats_list;
        WriteLine($"\n Eager Loading Setting Chosen: ------ '{eager_bool}' ------ ");
        if (!eager_bool)
        {
            var db_set_cats = db_context.Categories;
            //.IgnoreQueryFilters(["ProdCatIdFilter"])
            //.IgnoreQueryFilters(["CatCatIdFilter"])
            cats_list = db_set_cats.ToList();

        }
        else
        {
            cats_list = db_context.Categories.Include(c=>c.Products)
                .IgnoreQueryFilters(["ProdCatIdFilter"])
                .IgnoreQueryFilters(["CatCatIdFilter"])
                .ToList();
        }
        
        foreach (var item in cats_list)
        {
            WriteLine("- {0},{1},{2}",
            item.CategoryId, item.CategoryName, item.Products.Count);
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

    private static void LoadAllDataCatIdInDbContext(int cat_id)
    {
        using (var db_context = new NorthwindDb(cat_id))
        {
            List<Category>? categories_all = db_context.Categories.ToList();
            WriteLine($"Loading All Categories filtered for {cat_id}: ");
            foreach (var item in categories_all)
            {
                WriteLine($"- {item.CategoryId}: {item.CategoryName}");

            }
        }
    }

    private static void LoadAllProductViaQueryFilterCatIdDbContext(int cat_id)
    {
        using (var db_context = new NorthwindDb(cat_id))
        {
            List<Product>? prods_all = db_context.Products.ToList();
            WriteLine($"Loading All Prods by Cat Id '{cat_id}': ");
            foreach (var item in prods_all)
            {
                WriteLine($"- [cat: {item.CategoryId}]: {item.ProductName} [pid:{item.ProductId}]");
            }
        }
    }
    
    private static void LoadAllProductViaIGNOREQueryFilterCatIdDbContext(int cat_id)
    {
        using (var db_context = new NorthwindDb(cat_id))
        {
            List<Product>? prods_all = db_context.Products.IgnoreQueryFilters(["ProdCatIdFilter"]).ToList();
            WriteLine($"Loading All Prods by Cat Id '{cat_id}': ");
            int ctr = 1;
            int total = prods_all.Count;
            foreach (var item in prods_all)
            {
                WriteLine($"- [{ctr}/{total}][cat: {item.CategoryId}]: {item.ProductName} [pid:{item.ProductId}]");
                ctr++;
            }
        }
    }

    private static void FilterSweetCategories()
    {
        using var db_context = new NorthwindDb();

        IQueryable<Category> sweets = db_context.Categories.
            Where(c => c.Description == null ||
            c.Description.ToLower().Contains("sweet"));

        WriteLine("sweet stuff: ");

        foreach (var item in sweets)
        {
            WriteLine($"{item.CategoryName}: {item.Description}");
        }
    }

    private static void GetProductsOverPx(decimal price_limit = 100)
    {
        using (var db_context = new NorthwindDb())
        {
            var prods_under_px = db_context.Products.Where(p => p.Cost > price_limit).
                OrderByDescending(p => p.Cost);
            int i = 1;
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

    private static void CategoriesByProductWithMinStockSummary(decimal min_stock = 100)
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
            WriteLine($"[CatId {item.CategoryId}] {item.CategoryName} has {item.Products.Count} of Product(s)");
        }
    }

    private static void CategoriesByProductWithMinStockDetailed(decimal min_stock = 100)
    {
        using var db_context = new NorthwindDb();

        var query = db_context.Categories
            .TagWith("[TagWith] Products filtered by min stock and category.")
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

    private static void GetEntityByCatId(int cat_id)
    {
        using var db_context = new NorthwindDb();
        var result_entity = db_context.Categories.Where(c => c.CategoryId == cat_id).First();
        Console.WriteLine($"[id {result_entity.CategoryId}]: {result_entity.CategoryName}");
    }

    private static void GetEntityByCatIdUserInput()
    {
        using var db_context = new NorthwindDb();
        int cat_id;
        string? user_input;
        do
        {
            Write($"Enter a Category Id: ");
            user_input = ReadLine();
        } while (!int.TryParse(user_input, out cat_id));


        if (user_input is null)
        {
            throw new ArgumentException("Cannot be empty id");
        }
        WriteLine($"You entered: {cat_id}");
        var result_entity = db_context.Categories.Where(c => c.CategoryId == cat_id).First();
        Console.WriteLine($"[id {result_entity.CategoryId}]: {result_entity.CategoryName}");
    }

    private static void GetEntityByProdIdUserInput()
    {
        using var db_context = new NorthwindDb();
        int prod_id;
        string? user_input;
        do
        {
            Write($"Enter a Product Id: ");
            user_input = ReadLine();
        } while (!int.TryParse(user_input, out prod_id));

        if (user_input is null)
        {
            throw new ArgumentException("Cannot be empty id");
        }
        WriteLine($"You entered: {prod_id}");
        var result_entity = db_context.Products.Single(c => c.ProductId == prod_id);
        Console.WriteLine($"[Single()][id {result_entity.ProductId}]: {result_entity.ProductName}");
        result_entity = db_context.Products.First(c => c.ProductId == prod_id);
        Console.WriteLine($"[First()][id {result_entity.ProductId}]: {result_entity.ProductName}");
    }

    private static void GetProdsViaLIKECrabPatternMatching()
    {
        Write($"Matching 'crab' to Product Name: ");
        using var db_context = new NorthwindDb();
        var crab_like_query = db_context.Products.Where(p => EF.Functions.Like(p.ProductName, "%crab%"));

        foreach (var item in crab_like_query)
        {
            WriteLine($"[id {item.ProductId}]: {item.ProductName}");
        }
    }
    private static void GetProdsViaLIKEstrinputPatternMatching(string str_input)
    {
        Write($"Matching like 'str_input' to Product Name: ");
        //string? user_input = ReadLine();
        //while (string.IsNullOrWhiteSpace(user_input) || user_input.Contains(' '))
        //{
        //    Write($"Try again cunt: ");
        //    user_input = ReadLine();
        //}

        using var db_context = new NorthwindDb();
        //WriteLine($"Good job Einstein, lets look for : '{user_input}' in products");
        // get product name
        //"%mate%"
        var str_input_like_query = db_context.Products
            .Where(p => EF.Functions.Like(p.ProductName, $"%{str_input}%"));

        foreach (var item in str_input_like_query)
        {
            WriteLine($"[id {item.ProductId}]: {item.ProductName}");
        }

    }

    private static void GetProdsViaLIKEuserinputPatternMatching()
    {
        Write($"Please enter part of to Product Name: ");
        string? user_input = ReadLine();
        while (string.IsNullOrWhiteSpace(user_input) || user_input.Contains(' '))
        {
            Write($"Try again cunt: ");
            user_input = ReadLine();
        }

        using var db_context = new NorthwindDb();
        WriteLine($"Good job Einstein, lets look for : '{user_input}' in Products");
        var str_input_like_query = db_context.Products
            .Where(p => EF.Functions.Like(p.ProductName, $"%{user_input}%"));

        foreach (var item in str_input_like_query)
        {
            WriteLine($"[id {item.ProductId}]: {item.ProductName}");
        }

    }

    private static void GetProdByProdsIdFixedBySql()
    {
        using var db_context = new NorthwindDb();

        FormattableString fs_sql_str = $"select * from Products where Products.ProductId='69'";
        var query = db_context.Products
            .FromSql(fs_sql_str)
            .IgnoreQueryFilters(["ProdCatIdFilter"]);
        foreach (var item in query)
        {
            WriteLine($"{item.ProductId}: {item.ProductName}");
        }
    }
    private static void GetProdByProdsInputIdBySql(int input_pid)
    {
        using var db_context = new NorthwindDb();

        FormattableString fs_sql_str = $"select * from Products where Products.ProductId={input_pid}";
        var query = db_context.Products
            .FromSql(fs_sql_str)
            .IgnoreQueryFilters(["ProdCatIdFilter"]);
        foreach (var item in query)
        {
            WriteLine($"{item.ProductId}: {item.ProductName}");
        }
    }
    
    private static void TestingEagerLoading()
    {
        using var db_context = new NorthwindDb();

        DbSet<Category> cat_unrun_query = db_context.Categories; // this is IQuertable<Cat>: query defn
        List<Category> cat_unrun_list = db_context.Categories.ToList(); // this is a un-run sql query??

        WriteLine("running an un-run query 'cat_unrun_query: 'db_context.Categories'");
        foreach (var category in cat_unrun_query)
        {
            WriteLine($"[cid {category.CategoryId}]: {category.CategoryName}");
        }

        WriteLine("\nrunning an un-run list 'db_context.Categories.ToList()'");

        foreach (var category in cat_unrun_list)
        {
            WriteLine($"[cid {category.CategoryId}]: {category.CategoryName}");
        }
    }

    // tables
    // Catergory: cat_id, cat_name, description, ICollection<Product>
    // Product: p_id, p_name, cat_id, cat_name

    private static void GetCatId1_EagerLoad(int cat_id=1)
    {
        using var db = new NorthwindDb();

        Category? cat_first_row = db.Categories.Find(cat_id); // filter by unique id and return instance
        //Category? cat_first_row = db.Categories.SingleOrDefault(p=>p.CategoryId == 1); // filter by unique id and return instance

        if (cat_first_row is null)
        {
            WriteLine($"Could not find id: {cat_id}");
        }
        WriteLine($"- {cat_first_row?.CategoryId},{cat_first_row?.CategoryName} [exp: 1,Beverages]");
    }

    private static void GetCatId1To3_EagerLoad(int limit_results = 3)
    {
        using var db = new NorthwindDb();
        IQueryable<Category>? query = db.Categories.Take(limit_results);
        List<Category>? results_list = query.ToList(); // filter by unique id and return instance
        //Category? cat_first_row = db.Categories.SingleOrDefault(p=>p.CategoryId == 1); // filter by unique id and return instance

        if (results_list is null) return;
        foreach (var category in results_list)
            {
                WriteLine($"- {category.CategoryId},{category.CategoryName}");
            }

        var entities_tracked = db.ChangeTracker.Entries();
        if (entities_tracked is null) return;

        WriteLine("Printing tracked entities/entries:");
        foreach (var entry in entities_tracked)
        {
            WriteLine("- Type: {0}, State:{1}, Entry:{2}", entry.Entity.GetType().Name, entry.State, entry);
        }
    }

    private static void LazyLoadingProdPid1()
    {
        using var db = new NorthwindDb();
        var cats = db.Categories.ToList(); // load all cats

        foreach (var cat in cats)
        {
            WriteLine($"{cat.CategoryId},{cat.CategoryName}, {cat.Products.Count}");
        }
        //var products = categories[0].Products;
        // lazily get product 1
        foreach (var cat0_prod in cats[0].Products)
        {
            WriteLine($"[cats[0].prod {cat0_prod.ProductId}] {cat0_prod.ProductName} (lazy test)");

        }


        //var entities_tracked = db.ChangeTracker.Entries();
        //if (entities_tracked is null) return;
        //WriteLine("Printing tracked entities/entries:");
        //foreach (var entry in entities_tracked)
        //{
        //    WriteLine("- Type: {0}, State:{1}, Entry:{2}", entry.Entity.GetType().Name, entry.State, entry);
        //}

    }
    // entity stuff
    //https://learn.microsoft.com/en-us/ef/core/change-tracking/entity-entries

    // do a filter without selecting columns
    private static Func<int, int> squarer = x => x * x;

    private static void LazyLoadingWithNoTracking() {
        /// add request for 'products' 'no tracking query' 
        /// when enumerate
        /// - lazy loading to fetch the related [category] name
        /// 

        using var db_context = new NorthwindDb();

        var prod_list = db_context.Products.ToList();
        foreach (var prod in prod_list)
        {
            WriteLine($"[id: {prod.ProductId}] '{prod.ProductName}' is Category {prod.Category.CategoryName}");
        }
    
    }
}