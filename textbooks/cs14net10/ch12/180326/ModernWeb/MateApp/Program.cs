// See https://aka.ms/new-console-template for more information
using Northwind.EntityModels;

Console.WriteLine("Hello Northwind!");

var sqlite_db = new NorthwindContext();

// V1: Services
var product_service = new ProductService(sqlite_db);
var order_service   = new OrderService(sqlite_db);
//var mofo_service    = new MofoService(sqlite_db);

// V2: Services w' Benefits (sqlite_db)
//var product_service = new ProductService2().AddDbContext();
//var order_service = new OrderService2().AddDbContext();
//var mofo_service = new MofoService2().AddDbContext();

//
//product_service.GetAllCats();
//order_service.GetRecentAllOrders();

//ServiceContainer.GetTypeHowToCreateANwContext();

NormalFuckenMethod("im a stupid ass normal method");
GenericFkenMethod<string>();

GenericFkenMethod<int>();


GenericFkenMethod<NorthwindContext>();