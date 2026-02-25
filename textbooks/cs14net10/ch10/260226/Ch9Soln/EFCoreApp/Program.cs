using TPSharedLib.EntityModels;

Console.WriteLine("Hello EFCoreApp!");

using (NorthindCls db = new())
WriteLine($"Data-Provider: {db.Database.ProviderName}");

// TODO: setup
// - [DONE] add .sql item
// - [DONE] run sqlite command: initiate real northwind.db
// - [DONE] use sqlite viewer to check: northwind.db

// TODO: classes + annotations
// - add category class: 1-MANY [Categories[1]->Products[many]
// - add product class

// TODO: onModelCreation?
// - FluentAPI filters
// - decimal vs double??





