using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Win32;
//1. create builder
//- create a host for the website using defaults, like using Kestrel as the web server,
//- load configuration from appsettings.json,
//- setting environment variables,
//- setting command-line arguments, and
//- send logging output to the console and debug providers
var builder = WebApplication.CreateBuilder(args);

// 2. add options
//- registering dependency services by calling AddX methods on the Services collection
//- Other service registrations and configuration.
//builder.Services.AddRazorComponents();

var app = builder.Build(); //3. Build to make the web application object named app

#region Configure: HTTP Pipelines and routes
if (!app.Environment.IsDevelopment()) //7. hsts 
{
    app.UseHsts();
}
app.UseHttpsRedirection();
//4. route 
//app.MapGet("/", () => "Hello World!"); //-4. register request and response handlers in the HTTP pipeline. 
app.MapGet("/", () => $"{app.Environment.EnvironmentName}"); //-8. register request and response handlers in the HTTP pipeline. 
#endregion 

//6. add new endpoints
//- other file types can be returned from a web service
//- eg return a JSON document, or a web page:
app.MapGet("/data", () => Results.Json
(
    new
    {
        firstName = "Jason",
        lastName = "Bourne",
        age = 35
    }));
app.MapGet("/welcome", () => Results.Content(
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
    """,
    contentType: "text/html"));
//5. 
// Start the web server, host the website, and wait for requests.
app.Run(); // This is a thread-blocking call.
WriteLine("This executes after the web server has stopped!");