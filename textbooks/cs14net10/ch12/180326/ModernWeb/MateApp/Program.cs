// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.DependencyInjection;
using Northwind.EntityModels;

Console.WriteLine("Hello Northwind!");

var sqlite_db = new NorthwindContext();

//// V1: Services
//var product_service = new ProductService(sqlite_db);
//var order_service   = new OrderService(sqlite_db);
//var mofo_service    = new MofoService(sqlite_db);

// V2: Services w' Benefits (sqlite_db)
//var product_service = new ProductService2().AddDbContext();
//var order_service = new OrderService2().AddDbContext();
//var mofo_service = new MofoService2().AddDbContext();

//
//product_service.GetAllCats();
//order_service.GetRecentAllOrders();

//ServiceContainer.GetTypeHowToCreateANwContext();

//GetCat1(); // v1

// 2 scenarios:
// [1] consecutive dependencies

//var categories = new CategoryService1();
//categories.GetCatNames();
bool run = true;
if (!run)
{
    //v2
    var db = new NorthwindContext();
    var categories_service = new CategoryService2(db);
    var products_service = new ProductService2(db);

    categories_service.GetNames();
    products_service.GetNames();

}
if (!run)
{
    var service_factory = new ServiceFactoryNWContext();
    var prod_service = service_factory.CreateProductService();
    var cats_service = service_factory.CreateCategoryService();
    prod_service.GetNames();
    cats_service.GetNames();
}
if (!run)
{
    var service_factory = new ServiceFactoryNWContext2();
    var prod_service = service_factory.CreateProductService();
    var cats_service = service_factory.CreateCategoryService();
    prod_service.GetNames();
    cats_service.GetNames();
}
if (!run)
{
    var prods_service = ServiceFactoryNWContext3.CreateProductService();
    var cats_service = ServiceFactoryNWContext3.CreateCategoryService();
    prods_service.GetNames();
    cats_service.GetNames();
}
if (!run)
{
    var list_int = new BetterList<int>();
    list_int.AddToList(69);
    list_int.AddToList(420);
    foreach (var data in list_int.data)
    {
        WriteLine($"{data}");
    }
    //var ppl_list = new BetterList<PersonRecord>();
    //ppl_list.AddToList(new PersonRecord());
 }

// goals
// [A] services.AddDbContext<NorthwindContext>();
// [B] services.AddScoped<ProductService2>();


//var person1 = new PersonClass1();
if (!run)
{
    var evaluate = new EvaluateImportance();
    WriteLine($"evaluate.IsMoreImportant(420, 69): {evaluate.IsMoreImportant(69, 420)}");
    string res;
    res = evaluate.IsMoreImportant("mate", "broskies");
    WriteLine($"evaluate.IsMoreImportant(\"mate\", \"broskies\"): {res}");
    res = evaluate.IsMoreImportant("legendary", "broskies");
    WriteLine($"evaluate.IsMoreImportant(\"legendary\", \"broskies\"): {res}");


    // type decs
    //record PersonRecord(string? fname=null, string? lname = null);

}
    
if (!run)
{
    "mate".TonysWordCounter();
    var cslogger = new CSLogger();
    cslogger.Log("mateeee");
    cslogger.Log("sup...");
    cslogger.ErrorLog("we done...");
}

if (run)
{
    //IServiceCollection
    var service = new ServiceCollection();
    WriteLine($"service.Count: {service.Count}");
    //service.AddSingleton

   // keep learning Singleton through ai and ms f12 docs
}










