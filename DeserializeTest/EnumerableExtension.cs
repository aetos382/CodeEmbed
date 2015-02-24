using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    public static class EnumerableExtension
    {
        public static IOutputDictionary<TKey, TValue> ToOutputDictionary<TSource, TKey, TValue>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TSource, TValue> valueSelector)
        {
            var pairs = source.Select(x => new OutputKeyValuePair<TKey, TValue>(keySelector(x), valueSelector(x)));
            var result = new OutputDictionary<TKey, TValue>(pairs);

            return result;
        }
    }
}
