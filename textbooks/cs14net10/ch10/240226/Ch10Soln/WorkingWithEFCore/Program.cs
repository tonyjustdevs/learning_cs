using TPShared.EntityModels;

NwDbCls nw_db = new();
WriteLine("Welcome to WorkingWithEFCore!");
Console.WriteLine(Environment.CurrentDirectory);
WriteLine($"EF Code Provider: {nw_db.Database.ProviderName}");
WriteLine($"AppContext.BaseDirectory: {AppContext.BaseDirectory}");

// Disposes the database context.

//C:\Users\tonyp\learn\csharp\textbooks\cs14net10\ch10\240226\Ch10Soln\WorkingWithEFCore\bin\Debug\net10.0