namespace LINQ_Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ExtensionsLINQ
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate) 
        {
            var result = collection.Where( coll => !predicate(coll));

             return result;
        }
        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            for (int i = 0; i < count; i++)
            {
                foreach (var item in collection)
                {
                    //  A yield return statement is used to return each element one at a time.
                    yield return item;
                }
            }
        }
        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            foreach (var word in collection)
            {
                foreach (var suff in suffixes)
                {
                    if (!word.ToString().Trim().EndsWith(suff))
                    {
                        yield return word.Trim();
                    }
                }
            }
        }
    }
}
