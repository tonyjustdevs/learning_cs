namespace TPNS.Lumon.TPSharedModernLib; // File: TimeClock.generated.cs (auto-generated)

public partial class TimeClock
{
    // Declaration of a partial method (no body here)
    partial void OnInnieClockIn(SeveredEmployee employee);

    public void ClockIn(SeveredEmployee employee)
    {
        Console.WriteLine($"{employee.Name} clocked in at {DateTime.Now:T}.");

        // Call the hook - will do nothing if not implemented
        OnInnieClockIn(employee);
    }
}

