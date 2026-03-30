#region [1] Setup: Create Builder + Create App + app.UseFeatures()
using System.ComponentModel.DataAnnotations;
using TP.DataContext;
using TP.EntityModels;
using Scalar.AspNetCore; // To use MapScalarApiReference method.
using Microsoft.AspNetCore.HttpLogging; // To use HttpLoggingFields.


#region [1] Configure CORS: Allow Clients To Make Requests
const string corsPolicyName = "allowWasmClient";
#endregion

var builder = WebApplication.CreateBuilder(args); // Add services to the container.
builder.Services.AddOpenApi(); // Developers can use OAS for a web service to automatically
                               // generate strongly typed client-side code in their preferred language or library.
builder.Services.AddOpenApi(documentName: "v2");
builder.Services.AddValidation();
builder.Services.AddDbContext<NorthwindContext>();
builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = HttpLoggingFields.All;
    options.RequestBodyLogLimit = 4096; // Default is 32k.
    options.ResponseBodyLogLimit = 4096; // Default is 32k.
});


#region [2] Add CORS: allow diff port numbers from web service 
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: corsPolicyName,
      policy =>
      {
          policy.WithOrigins("https://localhost:5152",
          "http://localhost:5153");
      });
});
#endregion

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}
app.UseHttpLogging();
app.UseHttpsRedirection();
app.UseCors(corsPolicyName);
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


# region [3b] Add Routes: Query Parameters
app.MapGet("/weatherforecast2/{days:int?}",
    (int days=5) => GetWeatherTP(days))
    .WithName("GetWeatherForecastTP");
#endregion

#region [3c] Add Routes: Returning 'String'
app.MapGet("/hello_str",()=>"gday mate");
#endregion

#region [3d] Add Routes: Returning 'Anonymouse Type'
app.MapGet("/anon_type", () => new {firstName="James", lastName="Bourne", age=69});
#endregion

#region [3e] Add Routes: 'Post' With 'Validation'
app.MapPost("/products", (
    
    [Range(1, 100, ErrorMessage = "Product ID must be between 1 and 100.")]
    int productId,
    
    [Required] 
    string name) => TypedResults.Ok(productId))
    .DisableValidation(); // optional for specific endpoints

#endregion

#region [3f] Add Routes: Summary & Descriptions Keys

app.MapGet("/helloUsingMethods", () => "Hello world!")
    .WithSummary("This is a summary via fluentApi With.")
    .WithDescription("This is a description via fluentApi With.");

app.MapGet("/helloUsingAttributes",
    [EndpointSummary("This is a summary via attribute")]
    [EndpointDescription("This is a description via attribute")]
() => "Hello world!");

#endregion

#region [3g] Add Routes: OpenAPI document in YAML format
app.MapOpenApi("/openapi/{documentName}.yaml");
#endregion

#region [3h] Use XML doc comments to add metadata MinAPI endpt og lambda
// FROM lambda:
// app.MapGet("/hello", (string name) => $"Hello, {name}!");
// TO Hello
// - define the Hello method with XML doc comments
// - in any accessible class in your project

app.MapGet("/helloxml", Hello);

#endregion




app.MapCustomers();
app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
