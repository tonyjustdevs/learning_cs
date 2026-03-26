// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using TP.DataContext.Sqlite;
using TP.EntityModels;
using TP.EntityModels.Sqlite;

WriteLine("Hello EF Core World!");
WriteLine($"TPContextLogger.LogFileFullPath: {TPContextLogger.LogFileFullPath}");
bool run=true;
if (!run)
{
    //TPContextLogger.WriteToLog("mate");
    //TPContextLogger.WriteToLog("bro");
    //TPContextLogger.WriteToLog("sup!");

}
//var db = new NorthwindContext();
//var categories = db.Categories;
//foreach (var item in categories)
//{
//    WriteLine(item.CategoryId);
//}

var services = new ServiceCollection();

services.AddNorthwindContext();
WriteLine($" --- services: {services} [{services.GetType()}]");

var provider = services.BuildServiceProvider();
WriteLine($" --- provider: {provider} [{provider.GetType()}]");
//var services_returned = provider.GetService();

//var services = new IServiceCollection();