// See https://aka.ms/new-console-template for more information
using TP.EntityModels.Sqlite;

WriteLine("Hello EF Core World!");
WriteLine($"TPContextLogger.LogFileFullPath: {TPContextLogger.LogFileFullPath}");

TPContextLogger.WriteToLog("mate");
TPContextLogger.WriteToLog("bro");
TPContextLogger.WriteToLog("sup!");
