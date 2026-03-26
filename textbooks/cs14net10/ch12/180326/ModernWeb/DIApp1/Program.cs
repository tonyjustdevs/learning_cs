// See https://aka.ms/new-console-template for more information
using DI.Models;
//using Dumpify;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection.Metadata;
Console.WriteLine("Hello, Greetees!");


ServiceCollection servicesCollection = new();                       // add service collection
//servicesCollection.AddKeyedTransient<IGreeter, Aussie>("AusKey"); // Registration
//servicesCollection.AddKeyedTransient<IGreeter, Japanese>("JapKey"); // Registration
Console.WriteLine("1 adding aus");
servicesCollection.AddTransient<IGreeter, Aussie>(); // add service

Console.WriteLine("2 adding jap");
servicesCollection.AddTransient<IGreeter, Japanese>(); // add service
servicesCollection.AddTransient<IGreeter, Aussie>(); // add service
servicesCollection.AddTransient<IGreeter, Aussie>(); // add service

Console.WriteLine("3 building sp");
var serviceProvider = servicesCollection.BuildServiceProvider();
//serviceProvider.GetRequiredKeyedService<IGreeter>("JapKey").DoGreet();

Console.WriteLine("4a getting sp");
var services = serviceProvider.GetServices<IGreeter>(); //construtors called

Console.WriteLine("4b pre-sp-list");
var greeters = services.ToList();
Console.WriteLine("4c pst-sp-list");

int i = 1;
foreach (var item in greeters)
{
    Console.Write($"[{i}]: ");
    item.DoGreet();
    i++;
}

;
//serviceProvider = servicesCollection.BuildServiceProvider();
//serviceProvider?.GetService<IGreeter>()?.DoGreet();

//servicesCollection.AddTransient<IGreeter, AussieBogan>(); // add service

//serviceProvider?.GetService<IGreeter>()?.DoGreet();




//serviceProvider.GetRequiredKeyedService<IGreeter>("JapKey").DoGreet();
//serviceProvider.GetRequiredKeyedService<IGreeter>("JapKey").DoGreet();

//servicesCollection.AddTransient<IGreeter, Aussie>(); // add service
//servicesCollection.AddTransient<IGreeter, Japanese>(); // add service
//var igreet = serviceProvider.GetRequiredService<IGreeter>();    // gets LAST registered implementation
//var jap_greeter = serviceProvider.GetRequiredKeyedService<IGreeter>("AusKey");
//var aus_greeter = serviceProvider.GetRequiredKeyedService<IGreeter>("JapKey");

//var greeters = serviceProvider.GetServices<IGreeter>().ToList();         // get LIST of all implementations
//foreach (var greeter in greeters)
//{
//    greeter.DoGreet();
//}










//int i=0;
//foreach (var greeter in greeters)
//{

//    Console.WriteLine(i);
//    i++;
//}

////greeters.Dump(label: "Default output");
//greeters.Dump(label: "Include fields and non-public members",
//  members: new MembersConfig
//  {
//      IncludeFields = true,
//      IncludeNonPublicMembers = true,
//      IncludeProperties = true,
//      IncludeVirtualMembers=true
//  });


//Console.WriteLine($"GetService(typeof(IGreeter)1: {serviceProvider.GetService(typeof(IGreeter))}"); // DI.Models.Greet
//Console.WriteLine($"GetService(typeof(IGreeter)2: {serviceProvider.GetService(typeof(IGreeter))}"); // DI.Models.Greet
////Console.WriteLine($"GetService(typeof(Greet): {serviceProvider.GetService(typeof(Greet))}"); // null

//var greet_instance1 = (Greet)serviceProvider.GetRequiredService(typeof(IGreeter));
//var igreet_instance = (IGreeter)serviceProvider.GetRequiredService(typeof(IGreeter));
//var greeter = serviceProvider.GetService<IGreeter>();
//Console.WriteLine($"- greet_instance: [{greet_instance1}], greet_instance.GetType(): [{greet_instance1.GetType()}]");
//Console.WriteLine($"- igreet_instance: [{igreet_instance}], igreet_instance.GetType(): [{igreet_instance.GetType()}]");

//Console.WriteLine($"- greeter: [{greeter}], greeter.GetType(): [{greeter?.GetType()}]");

//greet_instance1.SayGreet();
//igreet_instance.SayGreet();
//greeter?.SayGreet();

//((IGreeter)greet_instance1).SayGreet();

//IServiceProvider





// What is Dependency Injection (DI)?
// - DI is the design pattern where classes
//  - receive its 'dependencies'
//  - from 'external' sources
//  - rather creating them interally

// 1. add extension
// 2. create interface
// 3. create class implementing interface

// main
// 1. create service_collection: serviceCollection
// 2. register service(s) (timeline + interface + implementation): serviceCollection.addX
// 3. build service_provider: helloProvider
// 4. resolve service to use it: helloService