namespace TP.SharedLibraries;

public class StrikeEventArgs : EventArgs
{
    public int StrikeNo { get; }
    public StrikeEventArgs(int strike_no)
    {
        StrikeNo = strike_no;
    }
}
