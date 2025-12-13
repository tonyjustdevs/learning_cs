using Microsoft.EntityFrameworkCore; 
namespace Proj2.NorthWind.EntityModels;

public class NWDB:DbContext
{
    DbSet<Proj2Category> P2Categories { get; set; }
    DbSet<Proj2Product> P2Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //base.OnConfiguring(optionsBuilder);
        // [1a]  [db.cs] add db class
        // [1b]  [db.cs] - creates nw_db instance 
        // [1c]  [db.cs] - inherit db_context
        // [1d]  [db.cs] - add db_sql_path to db.sql
        string file_path = "Proj2_Northwind.db";
        string conn_string = Path.Combine(Environment.CurrentDirectory,file_path);
        Console.WriteLine($"[OnConfiguring] conn_string: {conn_string}");
        optionsBuilder.UseSqlite($"Data Source={conn_string}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Use FluentApi to apply configs via methods [Property(), IsRequired(), HasMaxLength(), HasConversion(), HasData()]
        // [1] [Category]   CategoryName: [	"CategoryName" nvarchar (15) NOT NULL ]
        // [2] [Product]    Cost: [	"CategoryName" nvarchar (15) NOT NULL ]
    }
}
