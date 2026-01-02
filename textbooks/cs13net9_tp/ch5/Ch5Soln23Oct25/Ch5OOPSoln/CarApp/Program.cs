using System.Collections.Generic;
using TP.SharedNamespace;
Console.WriteLine("Hello To Car App!");

//Car camry= new(wheels: 4, isEV: true);

//Car camry= new(){ Wheels=4, IsEV=true}; // [C20122 inaccessible error]: Car cls is [internal]
                                        // - Car cls accessisble only in same assembly
                                        // - Program.cs is a seperate class/assembly 
Car camry= new(wheels: 4, isEV: true) { }; // [C20122 inaccessible error]: Car cls is [internal]
camry.Start();



//ConfigCulture()

ConfigCulture();
