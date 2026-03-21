using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.EntityModels;

//public interface IDbContext { /* common methods */ }

public partial class NorthwindContext : DbContext
{
    #region 1_CONSTRUCTORS
    // ------------------- 1_CONSTRUCTORS: BEG ------------------- //
    // - NorthwindContext()
    // - NorthwindContext(options)
#pragma warning disable CS8618

    public NorthwindContext()
    {
    }
    public NorthwindContext(DbContextOptions<NorthwindContext> options)
        : base(options)
    {
    }

#pragma warning restore CS8618
    // ------------------- 1_CONSTRUCTORS: END ------------------- //
    #endregion

    #region 2_PROPERTIES
    // ------------------- 2_PROPERTIES: BEG ------------------- //
    // - 8 Properties (aka tables)

    public string SomeRandomString { get; set; }   // ← this WILL show CS8618
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Shipper> Shippers { get; set; }
    public virtual DbSet<Supplier> Suppliers { get; set; }
    // ------------------- 2_PROPERTIES: END ------------------- //
    #endregion

    #region 2A_METHODS
    
    public static NorthwindContext Create()
    {
        return new NorthwindContext();
    }


    #endregion




    #region 3_ON_CONFIG
    // ------------------- 3_OnConfigurion(): BEG ------------------- //
    // - 1 OnConfiguring(optinosBuilder)

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        WriteLine("OnConfiguring() called.");
        if (!optionsBuilder.IsConfigured)
        {
            string database = "Northwind.db";
            string dir = Environment.CurrentDirectory;
            string path = string.Empty;
            if (dir.EndsWith("net10.0"))
            {
                // In the <project>\bin\<Debug|Release>\net10.0 directory.
                path = Path.Combine("..", "..", "..", "..", database);
            }
            else
            {
                // In the <project> directory.
                path = Path.Combine("..", database);
            }
            path = Path.GetFullPath(path); // Convert to absolute path.
            try
            {
                //NorthwindContextLogger.WriteLine($"Database path: {path}");
                WriteLine($"Database path: {path}");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            if (!File.Exists(path))
            {
                throw new FileNotFoundException(
                  message: $"{path} not found.", fileName: path);
            }
            optionsBuilder.UseSqlite($"Data Source={path}");
        //    optionsBuilder.LogTo(NorthwindContextLogger.WriteLine,
        //      [ Microsoft.EntityFrameworkCore
        //.Diagnostics.RelationalEventId.CommandExecuting ]);
        }
    }

    #endregion


    #region 4_ON_MODEL_CREATING
    protected override void OnModelCreating(
    ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            //entity.Property(e => e.Freight).HasDefaultValue(0.0);
            entity.Property(e => e.Freight).HasDefaultValue(0.0M);
        });
        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.Property(e =>
              e.Quantity).HasDefaultValue((short)1);
            entity.HasOne(d => d.Order)
              .WithMany(p => p.OrderDetails)
              .OnDelete(DeleteBehavior.ClientSetNull);
            entity.HasOne(d => d.Product)
              .WithMany(p => p.OrderDetails)
              .OnDelete(DeleteBehavior.ClientSetNull);
        });
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ReorderLevel)
              .HasDefaultValue((short)0);
            entity.Property(e => e.UnitPrice)
              .HasDefaultValue(0.0M);
            entity.Property(e => e.UnitsInStock)
              .HasDefaultValue((short)0);
            entity.Property(e => e.UnitsOnOrder)
              .HasDefaultValue((short)0);
            entity.Property(product => product.UnitPrice)
              .HasConversion<double>();
        });
        OnModelCreatingPartial(modelBuilder);
    }
    #endregion

    #region 5_ON_MODEL_CREATING_PARTIAL
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder); // DEFINE OURSELVES
#endregion
}
