namespace TP.SharedNamespace;

public class Angel
{
    string? AngelName;
    bool? Heavenly;

    Angel(string? angel_nm_param, bool heaven_param)
    {
        Heavenly = heaven_param;
        AngelName = angel_nm_param;
    }
}
