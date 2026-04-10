using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapGet("/", (HttpContext httpContext) => WriteHtml(httpContext,
    "<html><head><title>Title</title></head>" +
    "<body>\r\n\r\n<h1>This is a Heading</h1>" +
    "<p>This is a paragraph.</p>" +
    "</body>" +
    "</html>"));


app.Run();


void WriteHtml(HttpContext context, string html)
{
    //Console.WriteLine($"context.Features: {context.Features}");
    foreach (var feature in context.Features)
    {
        Console.WriteLine($"context.Feature: {feature}");
    }
    
    context.Response.ContentType = MediaTypeNames.Text.Html;
    context.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
    context.Response.WriteAsync(html);
}