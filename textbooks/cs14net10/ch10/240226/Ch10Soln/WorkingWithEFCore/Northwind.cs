
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TPShared.EntityModels;

public class NorthwindDbCls : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    { // sets the database connection string

    #if RUN_ALL_CRAP
        string conn1 = "Data Source=d:\\data\\TeamData.db";
        string conn2 = "Data Source=demo.db";

        string databasePath = Path.Combine("..", "..", "Northwind.db");
        string conn3 = $"Data Source={databasePath}";

        var configuration = BuildConfiguration();
        string conn4 = configuration.GetConnectionString("Default");

        string conn5 = databaseOptions.Value.ConnectionString;

        string conn6 = Environment.GetEnvironmentVariable("DATABASE_URL");
        string conn7 = configuration["DbConnection"];

        string conn8 = dataConnectionString ?? GetDataConnectionStringFromConfig();
        string conn9 = $"Data Source={storage.DatabaseFile}";
    #endif

        string tpConnectionString = "Data Source=Northwind.db";
        
        WriteLine($"Connection: {tpConnectionString}");
        
        optionsBuilder.UseSqlite(tpConnectionString);
    }
}
