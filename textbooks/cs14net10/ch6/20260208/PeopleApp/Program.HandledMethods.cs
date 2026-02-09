using TPSharedModernLib;


partial class Program
{

    private static void MethodToBeHandled2(object? sender, EventArgs e)
    {
        //WriteLine($"sender: {sender} (MethodToBeHandled2())\n");
        if (sender is null) return;
        if (sender is not Person p) return;

        WriteLine($"{p}: 'get fuckeds!' \t\t[MethodToBeHandled2()]\n");
    }

    private static void MethodToBeHandled(object? sender, EventArgs e)
    {
        //WriteLine($"sender: {sender} (MethodToBeHandled2())\n");
        if (sender is null) return;
        if (sender is not Person p) return;

        WriteLine($"{p}: 'get fucked!' \t\t[MethodToBeHandled()]\n");
    }
}
