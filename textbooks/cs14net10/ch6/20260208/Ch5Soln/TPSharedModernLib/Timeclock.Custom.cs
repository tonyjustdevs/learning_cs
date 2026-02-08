namespace TPNS.Lumon.TPSharedModernLib;
public partial class TimeClock
{
    // Declaration of a partial method (no body here)
    partial void OnInnieClockIn(SeveredEmployee employee)
    {
        if (employee.IsSevered)
        {
        WriteLine($"(Log){employee.Name} Innie has Severed in!");

        }
    }

}