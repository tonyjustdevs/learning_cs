using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using TP.Web2.Components; // To use App.
using TP.EntityModels;
using TP.DataContext.Sqlite;
#region [1] Configure the web server host and services.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents();
//add db context
var app = builder.Build();
#endregion

#region [2] Add Use Features
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}
#endregion

#region [3] Optional: add UseStaticWebAssets()
StaticWebAssetsLoader.UseStaticWebAssets(
    environment: builder.Environment,       //Console.WriteLine($"builder.Environment: {builder.Environment}");
    configuration: builder.Configuration);  //Console.WriteLine($"builder.Configuration: {builder.Configuration}");

#endregion


#region [4] Add Custom Delegate: AnonMethod (Plug into Pipeline)
app.Use(async (HttpContext context, Func<Task> next) =>
{
    RouteEndpoint? rep = context.GetEndpoint() as RouteEndpoint;

    if (rep is not null)
    {
        WriteLine($"Endpoint name: {rep.DisplayName}");
        WriteLine($"Endpoint route pattern: {rep.RoutePattern.RawText}");
    }

    if (context.Request.Path == "/bonjour")
    {
        // In the case of a match on URL path, this becomes a terminating
        // delegate that returns so does not call the next delegate.
        await context.Response.WriteAsync("Bonjour Monde!");
        return;
    }

    // We could modify the request before calling the next delegate.
    await next();

    // We could modify the response after calling the next delegate.
});
#endregion

app.UseHttpsRedirection();
app.UseAntiforgery();





#region [5] Add UseDefault  + UseStatic Files
bool useDefaultStuff = true;
if (useDefaultStuff)
{
    app.UseDefaultFiles();              // redirects / to index.html (or similar)
    app.UseStaticFiles();             // >.NET8 returns/serves file (index.html )
    //app.MapStaticAssets();              // >.NET9
}
#endregion

app.MapRazorComponents<App>();

#region [6] Add DBContext
//builder.Services.AddDbContext<NorthwindContext>();
//builder.Services.AddNorthwindContext();

#endregion


#region [7] AddRoutes via MapGet

bool addRoutes =true;
if (addRoutes)
{
    //app.MapGet("/", () => "Hello Vietnam!"); // this now '/' redirects to wwwroot/index.html because of UseDefaultFiles() + UseStaticFiles()
    app.MapGet("/env",      () => $"Environment is {app.Environment.EnvironmentName}");
    app.MapGet("/data",     () => Results.Json( 
        new { firstName="James", lastName="Bourne", age=69}
        //new { firstName = "Lionel", lastName = "Messi", age = 39}
        ));
    app.MapGet("/welcome",  () => Results.Content(content: "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Welcome to Tonys Basic HomePage</title>\r\n</head>\r\n<body>\r\n    this is the body!\r\n    \r\n</body>\r\n</html>",contentType:"text/html"));
    app.MapGet("/welcome1", () => Results.Content(
        content: 
            $"""
            <!doctype html>
            <html lang="en">
            <head>
            <title>Welcome to Northwind Web!</title>
            </head>
            <body>
            <h1>Welcome to Northwind Web!</h1>
            </body>
            </html>
            """
        ,
        contentType: 
            "text/html"));
    app.MapGet("/welcome2", () => Results.Content(
        content:
            $"""
            <!doctype html>
            <html lang="en">
            <head>
              <meta charset="utf-8" />
              <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
              <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
              <link href="site.css" rel="stylesheet" />
              <title>About Northwind Web</title>
            </head>
            <body>
              <div class="container">
                <div class="jumbotron">
                  <h1 class="display-3">About Northwind Web</h1>
                  <p class="lead">We supply products to our customers.</p>
                  <img src="categories.jpeg" style="height:200px;width:300px;" />
                </div>
              </div>
            </body>
            </html>
            """
        ,
        contentType: 
        "text/html"
        ));

    //app.MapGet("/env", () => Results.Text($"{app.Environment.EnvironmentName}",contentType:"text/html"));

}

#endregion


app.Run();
