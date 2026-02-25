using TPShared.EntityModels;
using NorthwindDbCls db = new();

WriteLine("Welcome to WorkingWithEFCore!");

WriteLine($"Provider: {db.Database.ProviderName}");
// Disposes the database context.