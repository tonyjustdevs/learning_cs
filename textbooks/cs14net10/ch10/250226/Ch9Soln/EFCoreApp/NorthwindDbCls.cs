using Microsoft.EntityFrameworkCore;

namespace TPSharedLib.EntityModels;

public class NorthwindDbCls : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string db_file = "Northwind.db";
        optionsBuilder.UseSqlite($"Data Source = {db_file}");
    }



}
