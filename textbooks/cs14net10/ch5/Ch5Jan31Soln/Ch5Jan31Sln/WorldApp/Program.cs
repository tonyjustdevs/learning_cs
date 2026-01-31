
//using France;         //[1]
//using Texas;          //[1]
//              
//Paris paris = new(); //[1] Compiler Error CS0104: 'reference' is an ambiguous reference between 'identifier' and 'identifier'


using France;           //[2]
using Tx= Texas;         //[2]
using Env=System.Environment;
Paris paris1 = new();    //[2] France.Paris
Tx.Paris paris2= new();

WriteLine("Welcome to WorldApp");
WriteLine("Env.MachineName: {0}", Env.MachineName);
WriteLine("Env.OSVersion: {0}",Env.OSVersion);
WriteLine("Env.CurrentDirectory: {0}",Env.CurrentDirectory);
