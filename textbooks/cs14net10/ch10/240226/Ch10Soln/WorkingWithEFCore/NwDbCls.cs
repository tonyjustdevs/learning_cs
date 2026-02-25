using Microsoft.EntityFrameworkCore;

namespace TPShared.EntityModels;

public class NwDbCls : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string db_name = "mofo.db";
        optionsBuilder.UseSqlite($"Data Source = {db_name}");
    }
}
