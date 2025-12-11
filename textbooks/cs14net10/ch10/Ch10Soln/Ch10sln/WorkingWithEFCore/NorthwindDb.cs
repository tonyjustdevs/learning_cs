using Microsoft.EntityFrameworkCore;
namespace Northwind.EntityModels;

public class NorthwindDb:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //base.OnConfiguring(optionsBuilder)
        //
        string db_path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
        string connection_string = $"Data Source={db_path}";
        
        Console.WriteLine($"db_path: {db_path}\n");

        Console.WriteLine($"connection_string: {connection_string}\n");
        optionsBuilder.UseSqlite(connection_string);
    }



}


// Unhandled exception. System.InvalidOperationException:
// No database provider has been configured for this DbContext.
// A provider can be configured by overriding the 'DbContext.OnConfiguring' method
// or by using 'AddDbContext' on the application service provider.
// If 'AddDbContext' is used, then also ensure that your DbContext type accepts a DbContextOptions<TContext> object
// in its constructor and passes it to the base constructor for DbContext.