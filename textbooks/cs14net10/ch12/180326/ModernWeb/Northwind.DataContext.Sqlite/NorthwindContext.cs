using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.EntityModels;

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

    #region 3_ON_CONFIG
    // ------------------- 2_OnConfigurion(): BEG ------------------- //
    // - 1 OnConfiguring(optinosBuilder)
    #endregion
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=../Northwind.db");

    
    
    
    #region 4_ON_MODEL_CREATING
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   // Use modelBuilder to
        // - Get Entity (SQLTables) & Configure Property (Columns) via FluentAPI:
        // -   .ValueGeneratedNever(),
        // -   .HasDefaultValue(0.0 or (short)0), 
        // -   .HasOne(col1).WithMany(col2).OnDelete(DeleteBehavior.ClientSetNull);
        // -   then Call OnModelCreatingPartial(modelBuilder)

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.CategoryId).ValueGeneratedNever();
        });
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.EmployeeId).ValueGeneratedNever();
        });
        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.OrderId).ValueGeneratedNever();
            entity.Property(e => e.Freight).HasDefaultValue(0.0);
        });
        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.Property(e => e.Quantity).HasDefaultValue((short)1);

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails).OnDelete(DeleteBehavior.ClientSetNull);
        });
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.ReorderLevel).HasDefaultValue((short)0);
            entity.Property(e => e.UnitPrice).HasDefaultValue(0.0);
            entity.Property(e => e.UnitsInStock).HasDefaultValue((short)0);
            entity.Property(e => e.UnitsOnOrder).HasDefaultValue((short)0);
        });
        modelBuilder.Entity<Shipper>(entity =>
        {
            entity.Property(e => e.ShipperId).ValueGeneratedNever();
        });
        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.Property(e => e.SupplierId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }
    #endregion

    #region 5_ON_MODEL_CREATING_PARTIAL
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder); // DEFINE OURSELVES
#endregion
}
