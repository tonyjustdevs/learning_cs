using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query;
using Northwind.EntityModels;

partial class Program
{

    private static void ListProducts(int[]? ints = null)
    {
        using (var db = new NorthwindDb())
        {
            var prods_query = db.Products;

            foreach (var prod in prods_query)
            {
                WriteLine($"{prod.ProductId}, {prod.ProductName}, {prod.Cost}, {prod.Cost}, {prod.Discontinued}");
            }
        }
    }

    private static void ListProducts2(int[]? ints = null)
    {
        using (var db = new NorthwindDb())
        {
            var prods_query = db.Products;
            
            bool need_to_print_title = true;

            foreach (var prod in prods_query)
            {
                if (need_to_print_title)
                {
                    WriteLine("| {0,-3} | {1,-35} | {2,8} | {3,5} | {4,12} |", "PID", "ProductName", "Cost", "Stock", "Discontinued");
                    need_to_print_title = false;
                }
                WriteLine("| {0,-3} | {1,-35} | {2,8} | {3,5} | {4,12} |", 
                    prod.ProductId, prod.ProductName, prod.Cost, prod.Stock,prod.Discontinued);
            }
        }
    }

    private static void ListProducts3(int[]? ints = null)
    {
        using (var db = new NorthwindDb())
        {
            var prods_query = db.Products;

            bool need_to_print_title = true;

            foreach (var p in prods_query)
            {
                if (need_to_print_title)
                {
                    WriteLine("| {0,-3} | {1,-35} | {2,8} | {3,5} | {4,12} |", "PID", "ProductName", "Cost", "Stock", "Discontinued");
                    need_to_print_title = false;
                }
                WriteLine($"| {p.ProductId,-3} | {p.ProductName,-35} | {p.Cost,8:C} | {p.Stock,5} | {p.Discontinued,12} |");
            }
        }
    }
    private static void ListProducts4_HighlightPIDS(int[]? ints = null)
    {
        using (var db = new NorthwindDb())
        {
            var prods_query = db.Products;

            bool need_to_print_title = true;

            foreach (var p in prods_query)
            {
                if (need_to_print_title)
                {
                    WriteLine("| {0,-3} | {1,-35} | {2,8} | {3,5} | {4,12} |", "PID", "ProductName", "Cost", "Stock", "Discontinued");
                    need_to_print_title = false;
                }

                var prevColor = ForegroundColor;
                if (ints.Contains(p.ProductId) || p.ProductId == 69)
                {
                    ForegroundColor = ConsoleColor.Blue;
                }

                if (ints.Contains(p.ProductId))
                {
                    ForegroundColor = ConsoleColor.Green;
                }
                WriteLine($"| {p.ProductId,-3} | {p.ProductName,-35} | {p.Cost,8:C} | {p.Stock,5} | {p.Discontinued,12} |");
                ForegroundColor = prevColor;
            }
        }
    }

    //In Program.Modifications.cs, add a method named AddProduct that returns a two-integer tuple, as shown in the following code:
    private static (int result, int pid) AddProduct(int categoryId, string productName, decimal? price, short? stock)
    //private static void AddProduct(int categoryId, string productName, decimal? price, short? stock)
    {
        // create instance
        Product new_prod = new()
        {
            CategoryId = categoryId,
            ProductName = productName,
            Cost = price,
            Stock = stock
        };

        using (var db = new NorthwindDb())
        {
            var new_entity = db.Products.Add(   new_prod);
            
            WriteLine($"\nState: {new_entity.State} PID: {new_prod.ProductId}");
            int db_rv =  db.SaveChanges();
            WriteLine($"\nState: {new_entity.State} PID: {new_prod.ProductId}");
                
            return (db_rv, new_prod.ProductId);
        }
    }
}
