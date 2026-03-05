
using Microsoft.EntityFrameworkCore;

namespace Northwind.EntityModels;

public class NorthwindDb : DbContext
{
    
    DbSet<Product> Products { get; set; }
    DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        //string db_name = "Northwind.db";                            // db name
        //string sql_connection_string = $"Data Source={db_name}";    // db sql string
        //optionsBuilder.UseSqlite(sql_connection_string);            

        string databaseFile = "Northwind.db";
        string path = Path.Combine(
          Environment.CurrentDirectory, databaseFile);
        string connectionString = $"Data Source={path}";
        WriteLine($"Connection: {connectionString}");
        optionsBuilder.UseSqlite(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .Property(p => p.CategoryName)
            .IsRequired()
            .HasMaxLength(15);

        //if (Database.ProviderName==" Microsoft.EntityFrameworkCore.Sqlite")
        //if (Database.ProviderName?.Contains("Sqlite") ?? false)
        if (Database.IsSqlite()) // apply sqlite logic
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Cost)
                .HasConversion<double>();
        }

    }

}

// add db class: Northwind.db via DbContext 
// add db instance to console proejct