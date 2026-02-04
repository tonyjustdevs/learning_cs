
using TPNS.TPSharedLibNet2;

partial class Program
    {
    public static void PassingParameters(int w, in int x, ref int y, out int z)
    {
        // out parameters cannot have a default and they
        // must be initialized inside the method.
        z = 100;
        // Increment each parameter except the read-only x.
        w++;
        // x++; // Gives a compiler error!
        y++;
        z++;
        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }
}

