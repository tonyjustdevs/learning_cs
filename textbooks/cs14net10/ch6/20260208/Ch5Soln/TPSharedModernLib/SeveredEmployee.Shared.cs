
namespace TPNS.Lumon.TPSharedModernLib;

public partial class SeveredEmployee
{

    public SeveredEmployee() { }
    public SeveredEmployee(string name) { Name = name; }

    public SeveredEmployee(string name, bool isSevered)
    {
        Name = name;
        IsSevered= isSevered;
    }
}
