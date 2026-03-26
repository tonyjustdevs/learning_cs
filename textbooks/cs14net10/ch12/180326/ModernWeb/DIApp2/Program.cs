using Microsoft.EntityFrameworkCore;
using Northwind.EntityModels;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello DI App 2!");


////DoShouterService();
//var animal_provider = new AnimalProvider();
//animal_provider.AddCatContextToAnimalDict();
////var cat_object = animal_provider.GetObjectAnimal(typeof(Cat));
////var cat1 = (Cat)cat_object;
//var cat2 = (Cat)animal_provider.GetObjectAnimal(typeof(Cat));

//var cat3 = animal_provider.GetAnimal<Cat>();
////Console.WriteLine($"{cat2} [{cat2.GetType()}]");
//var cat3 = animal_provider.GetAnimal<Cat>();


//DoGenericPrintingThing<int>();

//DoGenericPrintingThing("cunt");


//DoGenericPrintingThing(new { Name = "John", Age = 30 });

//IsGenLong<string>("mate");
//IsGenLong<int>(69);
//GetTAnimal<Cat>(new Cat());

//GetTAnimal<Cat>(null);
//GetTAnimal<Cat>();
////var something = GetCatAnimalOnly<Cat>();
//Console.WriteLine($"GetCatAnimalOnly<Cat>() ran:");
//Console.WriteLine($"- returned {GetCatAnimalOnly<Cat>()}");
////var cat3 = animal_provider.GetAnimal<Cat>();

//DoGenericPrint2(
//    new { Id = 69, Name = "Broskies" },
//    new NorthwindContext());

//var cat = GetCatAnimalOnly<Cat>();
var ap = new AnimalProvider();
ap.AddCatContextToAnimalDict();
var cat = ap.GetTAnimalOnly<Cat>();
Console.WriteLine($"\n{cat}  [from ap.GetTAnimalOnly<Cat>()]");

ap.AddTContextToAnimalDict<Dog>(()=>new Dog());
var dog = ap.GetTAnimalOnly<Dog>();
Console.WriteLine($"\n{dog}  [from ap.GetTAnimalOnly<Dog>()]");