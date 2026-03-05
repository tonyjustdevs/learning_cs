using Northwind.EntityModels;


// add instance

NorthwindDb db_instance =  new();
Console.WriteLine($"db_instance.ProvName: {db_instance.Database.ProviderName}");
