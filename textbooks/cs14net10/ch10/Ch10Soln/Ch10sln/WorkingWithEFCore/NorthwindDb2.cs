using Microsoft.EntityFrameworkCore;
namespace Northwind.EntityModels;

public class NorthwindDb2 : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options_builder)
    {
        Console.WriteLine($"Entered OnConfiguring()...\n");
        string file_name = "Northwind.db";
        string path = Path.Combine(Environment.CurrentDirectory, file_name);
        string conn_string = $"Data Source={path}";

        Console.WriteLine($"conn_string: {conn_string}\n");
        options_builder.UseSqlite(conn_string);
    }
}
