using Microsoft.EntityFrameworkCore; // To use DbContext and so on.
using Microsoft.EntityFrameworkCore.Diagnostics; // To use RelationalEventId.
namespace Northwind.EntityModels;
// This manages interactions with the Northwind database.
public class NorthwindDb : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(
      DbContextOptionsBuilder optionsBuilder)
    {
        string databaseFile = "Northwind.db";
        string path = Path.Combine(
          Environment.CurrentDirectory, databaseFile);
        string connectionString = $"Data Source={path}";
        WriteLine($"Connection: {connectionString}");
        optionsBuilder.UseSqlite(connectionString);

        //optionsBuilder.LogTo(WriteLine) // WriteLine is the Console method.
        optionsBuilder.LogTo(WriteLine, new[] { RelationalEventId.CommandExecuting })
        #if DEBUG
          .EnableSensitiveDataLogging() // Include SQL parameters.
          .EnableDetailedErrors()
        #endif
        ; // This is the end of the method call.
    }
}