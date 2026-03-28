
#region [1] Setup: Create Builder + Create App + app.UseFeatures()
using TP.DataContext;
using TP.EntityModels;
var builder = WebApplication.CreateBuilder(args); // Add services to the container.
builder.Services.AddOpenApi();

builder.Services.AddDbContext<NorthwindContext>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
#endregion

#region [2] Add Custom Data
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};
#endregion

# region [3i] Add Routes: OG
app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");
#endregion


# region [3i] Add Routes: Query Parameters
app.MapGet("/weatherforecast2/{days:int?}",
    (int days=5) => GetWeatherTP(days))
    .WithName("GetWeatherForecastTP");
#endregion

#region [3ii] Add Routes: Returning 'String'
app.MapGet("/hello_str",()=>"gday mate");
#endregion


#region [3iii] Add Routes: Returning 'Anonymouse Type'
app.MapGet("/anon_type", () => new {firstName="James", lastName="Bourne", age=69});
#endregion

app.MapCustomers();
app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
