partial class Program
{
    static void ShowMyNameSpace()
    {
        throw new Exception();
        string prog_namespace = typeof(Program).Namespace ?? "<null>";

        Console.WriteLine("namespace: {0}",
            prog_namespace);
    }
}