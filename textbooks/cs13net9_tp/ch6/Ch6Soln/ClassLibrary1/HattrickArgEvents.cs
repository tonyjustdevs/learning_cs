
namespace TP.SharedLibraries;

public class HattrickEventsArgs : EventArgs
{
    public int Goals;
    public HattrickEventsArgs(int goals)
    {
        Goals = goals;
    }
}