
namespace TP.SharedLibraries;

public struct DispVectComparer
{
    public static bool CompareDisplacementVectors(DisplacementVector dv1, DispVector2 dv2)
    {
        return dv1.X == dv1.X && dv1.Y == dv2.Y ? true : false;
    }
}
