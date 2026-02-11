namespace TPSharedModernLib;

public static class IEnumerableOfInt32Extensions {

    extension(IEnumerable<int> source)
    {
        public IEnumerable<int> IsGreaterThanThreshold(int threshold)
        {
            return source.Where(x => x < threshold);
        }
 
    }
}













public static class IEnumerableExtension
{
    public static bool IsEmptyOLDExtended(this IEnumerable<int> list)
    {
        Console.WriteLine("Running OLD extension method...");
        return !list.Any();
    }

}

public static class IEnumerableExtension2
{
    extension(IEnumerable<int>)
    {
        // add some static property?
        public static string ImSomeNewExtendedStrProp => "hiya mate";

        // add some static method?
    }
    extension(IEnumerable<int> list) { 
        public bool IsEmptyNEWExtended
        {
            get 
            { 
                Console.WriteLine("Running NEW extension method...");
                return !list.Any(); 
            }
        }
    }
}

// 1. create some list:
// int[] int_list = [1,2,3,4,5];

// 2. test extended method
//int_list.IsEmptyOldExtended();
