namespace TP.SharedNamespace;

public record HeadsetRecord
{
    public string? ProductName { get; init; }
    public string? Manufacturer { get; init; }

    public HeadsetRecord(string productnm, string manufacturer)
    {
        ProductName     = productnm;
        Manufacturer    = manufacturer;
    }

}

public record HeadsetClass
{
    public string? ProductName { get; init; }
    public string? Manufacturer { get; init; }


    public HeadsetClass(string productnm, string manufacturer)
    {
        ProductName = productnm;
        Manufacturer = manufacturer;
    }

}

public record HeadsetGetSetLessClass
{
    public string? ProductName;
    public string? Manufacturer;

    public HeadsetGetSetLessClass(string productnm, string manufacturer)
    {
        ProductName = productnm;
        Manufacturer = manufacturer;
    }
}