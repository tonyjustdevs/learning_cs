
namespace TPNS.Lumon.TPSharedModernLib;

public partial class SeveredEmployee
{
    public partial string Department {
        get => field;

        set
        {
            field = value;      // 1. set department = value
            if (value== "Macrodata Refinement")
            {
                WriteLine($"[NOTICE]{Name} has been assigned to Macrodata Refinement {DateTime.Now:U}");
            }
            // check department == "Macrodata Refinement" -> send notice
        }
    }

}
