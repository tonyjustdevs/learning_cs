namespace TPNS.TPSharedModernLib;

public class Headset(string name, string manufacturer)
{
    public string PropName { get; set; } = name;
    public string ManuName { get; set; } = manufacturer;

    public Headset() : this("Metaverse", "Facebook") { }
}