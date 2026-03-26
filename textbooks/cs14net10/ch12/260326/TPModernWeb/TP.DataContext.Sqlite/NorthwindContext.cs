using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using TP.EntityModels.Sqlite;

namespace TP.EntityModels;

public partial class NorthwindContext : DbContext
{
    public NorthwindContext()
    {
        WriteLine();
        WriteLine($" ------------ NorthwindContext() starting ------------ ");
        WriteLine($" ------------ NorthwindContext() ending ------------ ");
        WriteLine();
        
    }

    public NorthwindContext(DbContextOptions<NorthwindContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Shipper> Shippers { get; set; }
    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        WriteLine();
        WriteLine($" \n ------------ OnConfiguring starting ------------ \n ");
        string curr_dir = Environment.CurrentDirectory;
        string db_path;
        if (curr_dir.EndsWith("net10.0"))                   // debug dir
        {   
            WriteLine($" --- Running from :\n --- {curr_dir}");
            db_path = "../../../../Northwind.db";
        }
        else
        {                                                   // proj dir
            WriteLine($" --- Running from :\n --- {curr_dir}");
            db_path = "../Northwind.db";
        }
        db_path = GetFullPath(db_path);
        WriteLine($" --- db path calculated: \n --- {db_path}");
        if (!File.Exists(db_path))
        {
            WriteLine($" --- 'Northwind.db' file doesnt exist!");
            return;
        }
        WriteLine($" --- 'Northwind.db' file exist!");
        WriteLine($" --- Running optionsBuilder.UseSqlite(\n --- Data Source = {db_path})");
        optionsBuilder.UseSqlite($"Data Source = {db_path}");

        // do logs
        optionsBuilder.LogTo(
            WriteLine, 
            [Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.CommandExecuting]);
        //optionsBuilder.LogTo(
        //    TPContextLogger.WriteToLog,
        //    [Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.CommandExecuting]);

        WriteLine($" \n ------------ OnConfiguring ending ------------ \n");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.CategoryId);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.EmployeeId);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.OrderId);
            entity.Property(e => e.Freight).HasDefaultValue(0.0M);
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.Property(e => e.Quantity).HasDefaultValue((short)1);
            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails).OnDelete(DeleteBehavior.ClientSetNull);
            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ProductId);
            entity.Property(e => e.ReorderLevel).HasDefaultValue((short)0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0.0M);
            entity.Property(e => e.UnitsInStock).HasDefaultValue((short)0);
            entity.Property(e => e.UnitsOnOrder).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<Shipper>(entity =>
        {
            entity.Property(e => e.ShipperId);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.Property(e => e.SupplierId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
