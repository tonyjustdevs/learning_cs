
using System.Security.AccessControl;
using System.Security.Principal;

partial class Program
{


#if false

    private static void UnusedIdentityStuff() 
    {

        using System.Security.AccessControl;
        using System.Security.Principal;

        var identity = WindowsIdentity.GetCurrent();

        Console.WriteLine($"User: {identity.Name}");
        Console.WriteLine($"Is authenticated: {identity.IsAuthenticated}");
        Console.WriteLine($"Token: {identity.Token}");


        foreach (var group in identity.Groups)
        {
            Console.WriteLine(group.Value);
        }

        WriteLine("\nfile info:\n");

        var fileInfo = new FileInfo("coffee.txt");
        var acl = fileInfo.GetAccessControl();

        var rules = acl.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));

        foreach (FileSystemAccessRule rule in rules)
        {
            Console.WriteLine($"[IdRef: {rule.IdentityReference}] : [FileSysRights: {rule.FileSystemRights}] : [ACType: {rule.AccessControlType}]");
        }


        var principal = new WindowsPrincipal(identity);
        bool isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
        Console.WriteLine($"\nIs Admin: {isAdmin}");

        // create coffee.txt
        // add handle to coffee.txt
        // create buffer
        // connect handle & buffer:
        // write to buffer 




    }


#endif


}

