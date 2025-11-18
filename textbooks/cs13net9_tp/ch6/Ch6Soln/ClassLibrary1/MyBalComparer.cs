namespace TP.SharedLibraries;

public class MyBalComparer : Comparer<MyBal?>
{
    public override int Compare(MyBal? x, MyBal? y)
    {
        if (x is null && y is null) return 0;
        if (y is null) return -1;
        if (x is null) return 1;

        return x.CompareTo(y);
    }
}
