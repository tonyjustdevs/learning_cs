using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace TPSharedLib.EntityModels;
public class NorthindCls : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string db_file_name = "Northwind.db";
        string db_full_path = Combine(GetCurrentDirectory(), db_file_name);
        string connectinString = $"Data Source = {db_full_path}";
        WriteLine($"Connection: {connectinString}");
        optionsBuilder.UseSqlite(connectinString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().
            Property(p => p.CategoryName).
            IsRequired().
            HasMaxLength(15);
        modelBuilder.Entity<Category>().
            Property(p => p.Description).HasMaxLength(100);

        if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite") 
        {   // sqlite logic: cost -> becomes "money" type (instead of c# "decimal"
            modelBuilder.Entity<Product>().
                Property(property => property.Cost).
                HasConversion<double>();
        }
    }
    //    [Column("UnitPrice",TypeName="money")]    //	"UnitPrice" "money" 
    //public decimal Cost { get; set; }


}
