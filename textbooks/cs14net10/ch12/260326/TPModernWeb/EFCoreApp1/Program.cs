// See https://aka.ms/new-console-template for more information
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
var db = new NorthwindContext();
var categories = db.Categories;
foreach (var item in categories)
{
    WriteLine(item.CategoryId);
}