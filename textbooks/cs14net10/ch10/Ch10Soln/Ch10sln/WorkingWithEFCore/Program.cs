// See https://aka.ms/new-console-template for more information
using Northwind.EntityModels;

Console.WriteLine("Hello, WorkingWithEFCore!\n");


Console.WriteLine("Creating DB Instance\n");

//NorthwindDb nwdb = new NorthwindDb();
//nwdb.doOnConfig();
//Console.WriteLine($"nwdb.Database.ProviderName: {nwdb.Database.ProviderName}\n");




NorthwindDb2 nw_db2 = new();
Console.WriteLine($"nw_db2.Database.ProviderName(): {nw_db2.Database.ProviderName}");

// 0.includ pkg, add new class, using efc, add namspace
// 1a. pc nwdb : dbcontext cls
// 1b. pov onconfiguring(OB ob)
// 2. combinate path
// - create path
// - file name
// 3. create conencetion string connection${...}
// 4.optionsBuilder.sqlite(conn_str)
