using Northwind.EntityModels; // To use NorthwindDb, Category, Product.
using Microsoft.EntityFrameworkCore; // To use DbSet<T>.
partial class Program
{
    private static void FilterAndSort()
    {
        SectionTitle("Filter and sort");
        using NorthwindDb db = new();
        DbSet<Product> allProducts = db.Products;
        IQueryable<Product> filteredProducts =
          allProducts.Where(product => product.UnitPrice < 10M);
        IOrderedQueryable<Product> sortedAndFilteredProducts =
          filteredProducts.OrderByDescending(product => product.UnitPrice);
        WriteLine("Products that cost less than $10:");
        WriteLine(sortedAndFilteredProducts.ToQueryString());
        foreach (Product p in sortedAndFilteredProducts)
        {
            WriteLine("{0}: {1} costs {2:$#,##0.00}",
              p.ProductId, p.ProductName, p.UnitPrice);
        }
        WriteLine();
    }


    private static void JoinCategoriesAndProducts()
    {
        SectionTitle("Join categories and products");
        using NorthwindDb db = new();
        // Join every product to its category to return 77 matches.
        var queryJoin = db.Categories.Join(
          inner: db.Products,
          outerKeySelector: category => category.CategoryId,
          innerKeySelector: product => product.CategoryId,
          resultSelector: (c, p) =>
            new { c.CategoryName, p.ProductName, p.ProductId })
              .OrderBy(cp => cp.CategoryName);
        foreach (var p in queryJoin)
        {
            WriteLine($"{p.ProductId}: {p.ProductName} in {p.CategoryName}.");
        }
    }

    private static void GroupJoinCategoriesAndProducts()
    {
        SectionTitle("Group join categories and products");
        using NorthwindDb db = new();
        // Group all products by their category to return 8 matches.
        var queryGroup = db.Categories.AsEnumerable().GroupJoin(
          inner: db.Products,
          outerKeySelector: category => category.CategoryId,
          innerKeySelector: product => product.CategoryId,
          resultSelector: (c, matchingProducts) => new
          {
              c.CategoryName,
              Products = matchingProducts.OrderBy(p => p.ProductName)
          });
        foreach (var c in queryGroup)
        {
            WriteLine($"{c.CategoryName} has {c.Products.Count()} products.");
            foreach (var product in c.Products)
            {
                WriteLine($" {product.ProductName}");
            }
        }
    }

    private static void ProductsLookup()
    {
        using var db = new NorthwindDb();

        var prods_query = db.Categories.Join(
            inner: db.Products,
            outerKeySelector: c=>c.CategoryId,
            innerKeySelector: p=>p.CategoryId,
            resultSelector: (c,p_ents)=>new 
            {
                c.CategoryId, c.CategoryName, p_ents
            });

        // [1] cat_id, cat_nm, {prod1}
        // [2] cat_id, cat_nm, {prod2} ...
        // ...
        // [77]
        //int count=1;
        //foreach (var item in prods_query)
        //{
        //    WriteLine("[{0}] {1}: {2}, {3} [{4}]", count, item.CategoryId, item.CategoryName, item.p_ents.ProductId, item.p_ents.ProductName);
        //    count++;
        //}
        //var prodLookUpDict = ILookup<string, Product>()

        ILookup<string,Product> prods_lookup_dict = prods_query.ToLookup(
            keySelector: cp => cp.CategoryName,   // group??
            elementSelector: cp => cp.p_ents);

        foreach (var group_by_catname in prods_lookup_dict)
        {   
            WriteLine($"group_key: {group_by_catname.Key} count: {group_by_catname.Count()}");

            
            foreach (var item in group_by_catname)
            {
                WriteLine($"- [pid: {item.ProductId}] {item.ProductName} [catid:{item.CategoryId}]");

            }
        }
    }
}