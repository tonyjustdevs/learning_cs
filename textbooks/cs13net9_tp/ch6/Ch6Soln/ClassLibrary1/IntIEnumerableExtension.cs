namespace TP.SharedLibraries;

//public static class StringExtensionBlockClass
//{
//    extension(string source)
//    {
//        public string SomeStringExtensionMethod(string str_source)
//        {
//            return str_source;
//        }
//    }
//}

public static class IEnumerableOfInt32Extensions
{
    extension(IEnumerable<int> source) // Extension block.
    {
        public IEnumerable<int> WhereGreaterThan(int threshold)
        {
            return source.Where(x => x > threshold);
        }
        public bool IsEmpty
        {
            get
            {
                return !source.Any();
            }
        }
    }
}



//// create simple method extensionx
//public static class SomeStringExtensionClass
//{
//    public static string SomeStringExtensionMethod(this string str_source)
//    {
//        return str_source;
//    }
//}