using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args); // webappbuilder
var app = builder.Build();

// 1. add Void Method:DoWork()
// 1a. - includes threading.sleep(n)
// 1b. - prints upon completion

// 2.  Create 3 tasks with varying sleep times
// 2a. Note: Task.Run() accepts LAMBDA function: eg ()=>...

// 3.  Run all tasks Asynchronously


//DoSomeWork()


//Task.WaitAll(task1, task2, task3);






app.Run();










//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello world!");
//}); //app.Use(_ => handler);
//RequestDelegate some_instance_of_request_delegate;
// RD is a delegate, so its a variable that takes
// - INPUT:  HttpContext    context
// - OUPUT:  Task           task 

// todo:
// 1. Create Instance of RD: [req_del]
// 2. Use [req_del] in app.Run(req_del)


// 1.  client uses browser to look for url.

// 2.  dns resolution of requested url to an ip address, this is at OS level (locally) or through browser (internet)
// 3.  asp.net core web server kestrel receives raw http request from network
// 4.  kestrel parses raw http request
// 5.  aspnetcore constructs httpcontext, httprequest, httpresponse objects
// 5a. httpcontext is core object passed through middleware pipeline

// 5a.  () => "Hello World!" is run when '/' is requested
// 5b.  representing a http response of text/plain.
// 5c.  note: server replies with varying http-response depending on the original http-request

//https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-10.0