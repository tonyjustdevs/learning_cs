

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


//app.MapGet("/login", (HttpContext context) => {
//    string html_string = @"<!DOCTYPE html>
//        <html lang=""en"">
//        <head>
//            <meta charset=""UTF-8"">
//            <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
//            <title>Login Page</title>
//        </head>
//        <body>
//            <!-- <form action="""" method=""get""></form> -->
//             <form action=""/login2"" method=""post"">
//                <!-- <input type=""submit"" value=""Submit""> -->
//                <button type=""submit"">im a button</button>
//             </form>
//        </body>
//        </html>";
//    WriteTextToHTMLviaContextResponse(context, html_string);
//});

app.MapGet("/", (HttpContext context) => {
    string html_string = @$"

        <!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Login Page</title>
</head>
<body>
    <form action=""/come"" method=""get"">
        <input type=""text"" name=""first_name"" value="""" >
        <button type=""submit"">im a submit button to come</button>
    </form>
</body></html>
    
    ";
    WriteTextToHTMLviaContextResponse(context, html_string);
});




app.Run();

void WriteTextToHTMLviaContextResponse(HttpContext context, string html_string)
{
    context.Response.WriteAsync(html_string); // this is incorrect becausse [Task] is RETURNED but not used at all
    // it should be [AWAITED] OR [RETURNED]
 }

// goal
// - create a login page
//   - includes: login + pw forms
// - when submitted
//   - submits form to login via post somehow??
//   - process login success/fail

//app.MapGet("/1", (HttpContext context) => { });
//app.MapGet("/2", (HttpRequest request) => { });
//app.MapGet("/3", (HttpResponse response) => { });

// maps request to "/": Function()=>"Hello World!": 
// [Mapping] or Routing has several steps:
// - Route raw request to correct function/controller (but)
//   - There MAY through [Middleware] before reaching [Controller]
//   - Middleware does some authentication/validation

// [Controller] passes/handles [http] request data to [Service]
// [Service] does business logic (aka database interactions) returns required data-objects

// [Response] - template rendering or serialisation
