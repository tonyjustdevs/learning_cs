namespace TP.SharedLibraries;

public class MyBal : IComparable<MyBal>
{
    private decimal _balance;                                           // [1]  add [private_field_bal]
    public MyBal(decimal InitialDeposit) => _balance = InitialDeposit;  // [2]  add constr: sets [p_fld_bal]
    public decimal Balance { get { return _balance; } }                 // [3]  add get property decimal [private_field_bal]

    public int CompareTo(MyBal? other)
    {
        if (other is null) { return -1; }
        if (this is null) { return 1; }
        return this.Balance.CompareTo(other.Balance);
    }

    public void Deposit(decimal deposit) =>_balance += deposit;         // [4]  add method to increase void [private_field_bal]
    public bool Withdraw(decimal withdrawal_amt)                        // [5]  add method to withdraw bool [private_field_bal]
    {
        if (withdrawal_amt > _balance)
        {
            return false;
        }
        _balance -= withdrawal_amt;
        return true;
    }
}

// BalComparer : IComparer<MyBal?>

// apply the Compare logic
