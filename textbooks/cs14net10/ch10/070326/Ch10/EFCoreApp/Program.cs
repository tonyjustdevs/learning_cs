// See https://aka.ms/new-console-template for more information
//using Dumpify; // To use the Dump extension method.
     
Console.WriteLine("Hello, World!");

// 1. use db_first to create classes
// 2. run sqlite -init


//ConfigureConsole();
//QueryingCategories();

//LoadSingleCategoryEntityCatId4();

//LoadAllDataCat();
//FilterSweetCategories();
//GetProductsOverPx(1000);
//GetProductsOverPxUserInput();
//TxtbookQueryingProducts();
//CategoriesByProduct();
//CategoriesByProductSummary();/
//CategoriesByProductWithMinStockSummary(5);
//CategoriesByProductWithMinStockDetailed(69);
//GetEntityByCatId(5);
//GetEntityByCatIdUserInput();
//GetEntityByProdIdUserInput();

//GetProdsViaLIKECrabPatternMatching();

//GetProdsViaLIKEstrinputPatternMatching("cha");
//GetProdsViaLIKEuserinputPatternMatching();    

//LoadAllDataCatIdInDbContext(3);

//LoadAllProductViaQueryFilterCatIdDbContext(1);

//LoadAllProductViaIGNOREQueryFilterCatIdDbContext(1);
//GetProdByProdsIdFixedBySql();

//GetProdByProdsInputIdBySql(69);
//GetEagerTriggeredLoading(false);
//TestingEagerLoading();

//GetCatId1_EagerLoad(1);
//GetCatId1To3_EagerLoad(3);

//LazyLoadingProdPid1();
//WriteLine(squarer(5));
//LazyLoadingWithNoTracking();
//EagerAndLazyGetProdsPerEvenCatID();
//ExplictLoadingTesting();

//LazilyUntrackedProdAndCats();

//ListProducts();
//ListProducts2();
//ListProducts3();
ListProducts4_HighlightPIDS([67]);

//var results = AddProduct(11, "Tonys MysteryBox", 420M, 666);
//AddProduct(8, "Tonys MysteryBox", 420M, 666);
var res =  AddProduct(6, "Tonys MysteryBox2", 420.69M, 888);

WriteLine($"{res.result}, {res.pid}");
ListProducts4_HighlightPIDS([res.pid]);