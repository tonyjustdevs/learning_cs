
using Microsoft.EntityFrameworkCore;
using TPSharedLib.EntityModels;
Console.WriteLine("Hello EFCore World!");
using (NorthwindDbCls nw_db = new())
{
    nw_db.Database.EnsureCreated();
    WriteLine($"TestConnection: {nw_db.Database.CanConnect()}");
    WriteLine($"NwDb-DataProvider: {nw_db.Database.ProviderName}");

    //nw_db.Database.table
}

