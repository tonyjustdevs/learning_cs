// See https://aka.ms/new-console-template for more information
//using Dumpify; // To use the Dump extension method.

using Dumpify;

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
//ListProducts4_HighlightPIDS([68]);s
//ListProducts4_HighlightPIDS([68]);
//var res = AddProduct(6, "Tonys Mystery68Box", 420M, 666);
//var res = AddProduct(2, "Tonys Mystery69Box", 421M, 667);
//WriteLine($"{res.result}, {res.pid}");
//ListProducts4_HighlightPIDS([68]);

//ListAndHighlightProducts();
//var new_prod_res = AddNewProduct("Tonys Fun-Box-1", 69, 420, false, 3);
//var new_prod_res2 = AddNewProduct("Tonys Fun-Box-2", 79, 422, true, 6);
//var new_prod_res3 = AddNewProduct("Tonys Fun-Box-3", 89, 423, false, 1);

//ListAndHighlightProducts([new_prod_res.pid, new_prod_res2.pid, new_prod_res3.pid]);


//var res = IncreaseProdPx("Fun");

//if (res.entries_affected>0)
//{
//    WriteLine($"{res.pid} price increased sucessfully!");
//}


ListAndHighlightProducts();
var del_res = DeleteProdsByWhereCriteria("tony");
if (del_res.products_deleted_no > 0 && del_res.products_deleted_list is not null)
{
	WriteLine($"Deleted '{del_res.products_deleted_no}' Successfully: ");
	foreach (var prod in del_res.products_deleted_list)
	{
		WriteLine($"- {prod.ProductName}");

	}
}
ListAndHighlightProducts();

