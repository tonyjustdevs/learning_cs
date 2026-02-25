using Microsoft.EntityFrameworkCore;

namespace TPSharedLib.EntityModels;
public class NorthindCls : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string db_file_name = "Northwind.db";
        string db_full_path = Combine(GetCurrentDirectory(), db_file_name);
        string connectinString = $"Data Source = {db_full_path}";
        WriteLine($"Connection: {connectinString}");
        optionsBuilder.UseSqlite(connectinString);
    }
}
