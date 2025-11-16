namespace TP.SharedLibraries;
public partial class Person
{
    public event EventHandler? StrikeEventHandler;
}

public class StrikeEventArgs : EventArgs
{
    public int StrikeNo { get; }
    public StrikeEventArgs(int strike_no)
    {
        StrikeNo = strike_no;
    }
}
