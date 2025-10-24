
using TP.SharedNamespace;

// create bank accounts

TPBankAccount ba1 = new("tony cules", 420.69M);

Console.WriteLine($"ba1.AccountName: {ba1.AccountName}");
Console.WriteLine($"ba1.Balance: {ba1.Balance}");
Console.WriteLine($"ba1.IntRate: {TP.SharedNamespace.TPBankAccount.FixedInterestRate}");
