using Microsoft.EntityFrameworkCore; // To use DbContext and so on.
using Microsoft.EntityFrameworkCore.Diagnostics; // To use RelationalEventId.
namespace Northwind.EntityModels;
// This manages interactions with the Northwind database.
public class NorthwindDb : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    //public DbSet<Question> Questions{ get; set; }

    private readonly int _cat_id;
    public NorthwindDb(int cat_id)
    {
        _cat_id = cat_id;
    }
    public NorthwindDb() { }
    protected override void OnConfiguring(
      DbContextOptionsBuilder optionsBuilder)
    {
        string databaseFile = "Northwind.db";
        string path = Path.Combine(
          Environment.CurrentDirectory, databaseFile);
        string connectionString = $"Data Source={path}";
        WriteLine($"Connection: {connectionString}");
        optionsBuilder
            //.UseLazyLoadingProxies()
            .UseSqlite(connectionString);

        //optionsBuilder.LogTo(WriteLine) // WriteLine is the Console method.
        optionsBuilder.LogTo(WriteLine, new[] { RelationalEventId.CommandExecuting })
        #if DEBUG
          .EnableSensitiveDataLogging() // Include SQL parameters.
          .EnableDetailedErrors()
        #endif
        ; // This is the end of the method call.
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        //modelBuilder.Entity<Category>().HasQueryFilter("CatCatIdFilter",c => c.CategoryId == _cat_id);

        //modelBuilder.Entity<Product>().HasQueryFilter("ProdCatIdFilter",p => p.CategoryId == _cat_id);
          //.HasQueryFilter("TenantFilter", customer => customer.TenantId == tenantId);
    }
}