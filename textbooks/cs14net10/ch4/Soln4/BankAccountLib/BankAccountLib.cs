namespace BankAccountLib;

public class BankAcct
{
    static void Withdraw(string acct_name, double amt)
    {
        if (string.IsNullOrWhiteSpace(acct_name))
        {
            throw new ArgumentException(nameof(acct_name));
        }

        if (amt<0)
        {
            throw new ArgumentOutOfRangeException(nameof(amt),$"Cannot withdraw a negative amount: {nameof(amt)}");
        }
    }
}
