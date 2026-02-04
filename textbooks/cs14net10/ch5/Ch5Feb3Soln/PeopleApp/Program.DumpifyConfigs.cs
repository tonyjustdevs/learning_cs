using Dumpify;

partial class Program
{
    public static void ConfigureDumpify()
    {
        DumpConfig.Default.MembersConfig.IncludeFields = true;
        DumpConfig.Default.MembersConfig.IncludeProperties = true;
        DumpConfig.Default.MembersConfig.IncludeNonPublicMembers = true;
        DumpConfig.Default.MembersConfig.IncludePublicMembers = true;
        DumpConfig.Default.MembersConfig.IncludeVirtualMembers = true;
        DumpConfig.Default.TableConfig.ShowMemberTypes = true;
    }


}

