using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query;
using Northwind.EntityModels;
using System;
using System.Data;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
            
            var new_entity = db.Products.Add(new_prod);
            
            WriteLine($"\nState: {new_entity.State} PID: {new_prod.ProductId}");
            int db_rv =  db.SaveChanges();
            WriteLine($"\nState: {new_entity.State} PID: {new_prod.ProductId}");
                
            return (db_rv, new_prod.ProductId);
        }
    }

    private static void ListAndHighlightProducts(int[]? ints=null)
    {
        using var db = new NorthwindDb();

        var products = db.Products;

        WriteLine("| {0,-3} | {1,-35} | {2,8} | {3,5} | {4,5} | ",
            "PID", "Product", "Price", "Stock", "Disc");
        var prev_color = ForegroundColor;
        foreach (var p in products)
        {
            if (ints.Contains(p.ProductId))
            {
                ForegroundColor = ConsoleColor.DarkRed;
            }
            
            WriteLine("| {0,-3} | {1,-35} | {2,8} | {3,5} | {4,5} | ",
                p.ProductId, p.ProductName, p.Cost, p.Stock, p.Discontinued);
            ForegroundColor = prev_color;
        }
    }

    private static (int entries_written, int pid) AddNewProduct(
        string prod_name, decimal cost, short stock, bool disc, int cat_id
        )
    {
        using var db = new NorthwindDb();
        var products = db.Products;
        var new_prod = new Product() // create product instance
        {
            ProductName = prod_name,
            Cost = cost,
            Stock = stock,
            Discontinued = disc,
            CategoryId = cat_id
        };
        var entity = products.Add(new_prod);
        WriteLine($"Entity.State: {entity.State}, PID: {new_prod.ProductId} [pre-save]");

        int entries_written = db.SaveChanges();
        WriteLine($"Entity.State: {entity.State}, PID: {new_prod.ProductId} [pst-save]");
        
        return (entries_written, new_prod.ProductId);
    }

    private static (int entries_affected, int pid) IncreaseProdPx(string? LikeProductName=null)
    {
        using var db = new NorthwindDb();
        //WriteLine($"product_default: {default(Product)}");

        Product? product_instance = db.Products
            .Where(p => EF.Functions.Like(p.ProductName, $"%{LikeProductName}%"))
            .FirstOrDefault();
        
        if (product_instance is null) return (0, 0);
        
        var entity = db.Entry(product_instance); // product_instance => Castle.Proxies.ProductProx
        
        if (LikeProductName is null)
        {
            WriteLine("Note: No string entered! Returning first entry in db...");
            WriteLine($"Entity.State: {entity.State} [exp: Unchanged], PID: {product_instance.ProductId} [exp: 1] [pre-save]");
            return (0, product_instance.ProductId);
        }

        int entries_written;
        if (LikeProductName is not null && product_instance is not null)
        {
            // ------------- [1] pre-update ------------- //
            //entity = db.Entry(product_instance);
            WriteLine($"\nEntity.State: {entity.State} [exp: Unchanged], " +
                $"PID: {product_instance.ProductId}, " +
                $"Px: {product_instance.Cost} [pre-chg]");

            // ------------- [2] conduct update ------------- //
            // ------------- [3] pre-save to db ------------- //
            product_instance.Cost += 1000;
            //entity = db.Entry(product_instance);
            db.ChangeTracker.DetectChanges();
            WriteLine($"\nEntity.State: {entity.State} [exp: Modified], " +
                $"PID: {product_instance.ProductId}, " +
                $"Px: {product_instance.Cost} [pst-chg, pre-save]");

            // ------------- [4] pst-save to db ------------- //
            entries_written = db.SaveChanges();
            //entity = db.Entry(product_instance);

            WriteLine($"\nEntity.State: {entity.State} [exp: Unchanged], " +
                $"PID: {product_instance.ProductId}, " +
                $"Px: {product_instance.Cost} [pst-chg, pst-save]");


            return (entries_written, product_instance.ProductId);
        }
        WriteLine("something went wrong!");
        return (420, 420);
    }

    static (int products_deleted_no, List<Product>? products_deleted_list) DeleteProdsByWhereCriteria(string matching_string)
    {
        using var db = new NorthwindDb();

        var products_query = db.Products.Where(p => p.ProductName.StartsWith(matching_string)).ToList();
        if (products_query is null) 
        {
            WriteLine("Nothing to delete!");
            return (0, null);
        }

        var products_list = products_query.ToList();

        WriteLine("\nList of Products to Delete: ");
        foreach (var product in products_list)
        {
            WriteLine($"- {product.ProductName}");
        }
        WriteLine("\nPress 'Y' to Delete.");
        ConsoleKeyInfo key_pressed = ReadKey();
         
        db.RemoveRange(products_query);

        int products_deleted = db.SaveChanges();
        return (products_deleted, products_list);
    }

    private static int DeleteExecProdsAbovePx(decimal? px_ceiling)
    {
        using var db = new NorthwindDb();
        return db.Products
            .Where(p => p.Cost > px_ceiling)
            .ExecuteDelete();
    }

    private static int SetPriceViaExec(string string_match, decimal inflation_pct)
    {
        using var db = new NorthwindDb();

        var prods = db.Products.Where(p => EF.Functions.Like(p.ProductName, $"%{string_match}%"));
        
        return prods.ExecuteUpdate(s => s.SetProperty(
            p => p.Cost,
            p => p.Cost*(1+inflation_pct)));

    }




    // --------------- end of partial program --------------- //
}

        //var entities = db.ChangeTracker.Entries();
        //foreach (var ent in entities)
        //{
        //    ent.
        //    foreach (var memberEntry in ent.Members)
        //    {
        //        Console.WriteLine(
        //            $"- {memberEntry.Metadata.Name} is of type {memberEntry.Metadata.ClrType.ShortDisplayName()} and has value {memberEntry.CurrentValue}");
        //    }
        //}
//- Member ProductId is of type int and has value 78
//- Member CategoryId is of type int and has value 6
//- Member Cost is of type decimal? and has value 420
//- Member Discontinued is of type bool and has value False
//- Member ProductName is of type string and has value Tonys Mystery68Box
//- Member Stock is of type short? and has value 666
//- Member Category is of type Category and has value
        //if (key_pressed.Key==ConsoleKey.Y)
        //{
        //    db.RemoveRange(products_query);

        //}