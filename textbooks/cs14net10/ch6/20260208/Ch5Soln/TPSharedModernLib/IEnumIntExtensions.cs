using System.Collections.Generic;

namespace TPSharedModernLib;

public static class IEnumIntExtensions
{
    extension(IEnumerable<int>) { 
        public static IEnumerable<int> Range(int start, int end)
        {
            return System.Linq.Enumerable.Range(start, end);
        }
    }
    
    extension(IEnumerable<int> source) { 
        // add property
        public bool IsItEmpty => !source.Any();
        public IEnumerable<int> IsGreaterThan(int threshold) => source.Where(x => x > threshold);
    }
}


// testing
//list.IsItEmpty // False
//empty_list.IsItEmpty // True
//list.IsGreaterThan // returns some property
