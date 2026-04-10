using System.Runtime.InteropServices;
using System.Text.Json;

partial class Program
{

    
}

public static class TonysBuilderExtensions
{
    public static void TPDumpConfigsToJson(this WebApplicationBuilder builder)
    {

        var config = builder.Configuration.AsEnumerable(); // Flatten config into key-value pairs
        var cleaned = config // Optional: remove null values
            .Where(kv => kv.Value != null)
            .ToDictionary(kv => kv.Key, kv => kv.Value);
        var clean_json = JsonSerializer.Serialize(cleaned, new JsonSerializerOptions { WriteIndented = true });// Serialize
        var dirty_json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true }); // Serialize
        File.WriteAllText("tp_config_clean_dump.json", clean_json); // Write to file
        File.WriteAllText("tp_config_dirty_dump.json", dirty_json); // Write to file

 
    }


    public static void TPDumpServcesToJson(this WebApplicationBuilder builder)
    {
        var services = builder.Services.Select(s => new
        {
            Service = s.ServiceType.FullName,
            Implementation =
             s.ImplementationType?.FullName ??
             s.ImplementationInstance?.GetType().FullName ??
             "Factory/Unknown",
            Lifetime = s.Lifetime.ToString()
        });
        var json = JsonSerializer.Serialize(services, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("tp_services_dump2.json", json);




    }

}