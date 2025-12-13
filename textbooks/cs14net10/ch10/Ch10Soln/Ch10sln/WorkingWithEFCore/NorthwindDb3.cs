using Microsoft.EntityFrameworkCore;

namespace Northwind.EntityModels;

public class NorthwindDb3 : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string file_name = "Northwind.db";
        string db_path = Path.Combine(Environment.CurrentDirectory, file_name);
        Console.WriteLine($"[in NwDb3.OnConfig()] db_path: {db_path}");
        string conn_str = $"Data Source ={db_path}";
        Console.WriteLine($"[in NwDb3.OnConfig()] conn_str: {conn_str}");
        optionsBuilder.UseSqlite(conn_str);

    }
}
