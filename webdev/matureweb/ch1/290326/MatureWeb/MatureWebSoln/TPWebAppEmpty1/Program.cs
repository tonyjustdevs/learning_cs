

using System.Text.Json;

var web_app_builder = WebApplication.CreateBuilder(args);
//Microsoft.Extensions.Logging.Loggerbuilder

var app = web_app_builder.Build();

// program end.

//





bool exportstuff = false;
if (exportstuff)
{
    web_app_builder.TPDumpConfigsToJson();
    web_app_builder.TPDumpServcesToJson();

}