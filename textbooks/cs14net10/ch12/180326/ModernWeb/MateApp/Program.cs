// See https://aka.ms/new-console-template for more information
using Northwind.EntityModels;

Console.WriteLine("Hello, Mate!");

//NorthwindContextLogger.WriteLine("hey mate");
//GetCategoriesId1();
//GetCategoriesId2();
//GetCategoriesId3();

GetCategoriesId4_DI(new NorthwindContext());

var product_service = new ProductService(new NorthwindContext());


//DbFactory()