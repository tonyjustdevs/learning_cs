using Microsoft.AspNetCore.Hosting.StaticWebAssets;

var builder = WebApplication.CreateBuilder(args);


#region StaticStuff
StaticWebAssetsLoader.UseStaticWebAssets(
    environment: builder.Environment,       //Console.WriteLine($"builder.Environment: {builder.Environment}");
    configuration: builder.Configuration);  //Console.WriteLine($"builder.Configuration: {builder.Configuration}");
#endregion
var app = builder.Build();


#region Redirects: Security
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}
app.UseHttpsRedirection();
#endregion

#region Redirects: Static Content
bool useDefaultStuff = true;
if (useDefaultStuff)
{
    app.UseDefaultFiles();              // redirects / to index.html (or similar)
    app.UseStaticFiles();             // >.NET8 returns/serves file (index.html )
    //app.MapStaticAssets();              // >.NET9
}
#endregion
#region Routes
//app.MapGet("/", () => "Hello Vietnam!"); // this now '/' redirects to wwwroot/index.html because of UseDefaultFiles() + UseStaticFiles()


app.MapGet("/data", () => Results.Json( 
    new { firstName="James", lastName="Bourne", age=69}
    //new { firstName = "Lionel", lastName = "Messi", age = 39}
    ));

app.MapGet("/welcome", () => Results.Content(content: "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Welcome to Tonys Basic HomePage</title>\r\n</head>\r\n<body>\r\n    this is the body!\r\n    \r\n</body>\r\n</html>",
    contentType:"text/html"));

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

app.MapGet("/env", () => Results.Text($"{app.Environment.EnvironmentName}",contentType:"text/html"));
#endregion

app.Run();
