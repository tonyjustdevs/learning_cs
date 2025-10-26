using System.Diagnostics.CodeAnalysis;
namespace TP.SharedNamespace;

public class BadSavingsAccount
{
    public string? AccountName;
    public decimal Balance;
    public static decimal InterestRate;

}

public class BetterSavingsAccount
{
    public string? AccountName;
    public decimal Balance;
    public static decimal InterestRate;
    
    [SetsRequiredMembers]
    public BetterSavingsAccount(string? acctname_param, decimal bal_param)
    {
        //
    }

}

