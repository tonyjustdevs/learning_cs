
namespace TP.SharedNamespace;

public class TPBankAccount
{
    public string? AccountName; // instance mbr
    public decimal? Balance;    // instance mbr
    public static readonly decimal? FixedInterestRate = 0.42M; // fixed mbr
    
    public TPBankAccount(
        string? acct_name,
        decimal? bal)
    {
        AccountName = acct_name;
        Balance = bal;
    }
}
