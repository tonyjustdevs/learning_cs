using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using TP.EntityModels;

namespace TP.DataContext.Sqlite;
public static class NorthwindContextExtensions
{
    public static IServiceCollection AddNorthwindContext(this IServiceCollection services)
    {

        // do something herE??

        services.AddDbContext<NorthwindContext>(options =>
        {
            string db_path = "../Northwind.db";
            options.UseSqlite($"Data Source={db_path}");

            options.LogTo(WriteLine,
                [Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.CommandExecuting]);
        },

        optionsLifetime: ServiceLifetime.Transient, 
        contextLifetime: ServiceLifetime.Transient

        );
        

        return services;
    }

}
