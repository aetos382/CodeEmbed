namespace DeserializeTest
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class OutputDictionaryExtension
    {
        [Pure]
        public static IOutputDictionary<TKey, TValue> ToOutputDictionary<TSource, TKey, TValue>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TSource, TValue> valueSelector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(valueSelector != null);

            return ToOutputDictionary(source, keySelector, valueSelector, null);
        }

        [Pure]
        public static IOutputDictionary<TKey, TValue> ToOutputDictionary<TSource, TKey, TValue>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TSource, TValue> valueSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(valueSelector != null);

            var pairs = source.Select(x => new OutputKeyValuePair<TKey, TValue>(keySelector(x), valueSelector(x)));
            var result = new OutputDictionary<TKey, TValue>(pairs, keyComparer);

            return result;
        }

        [Pure]
        public static IOutputDictionary<TKey, TValue> ToOutputDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return ToOutputDictionary(source, null);
        }

        [Pure]
        public static IOutputDictionary<TKey, TValue> ToOutputDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> source,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            var result = new OutputDictionary<TKey, TValue>(source, keyComparer);
            return result;
        }

        [Pure]
        public static IOutputDictionary<TKey, TValue> ToOutputDictionary<TKey, TValue>(
            this Dictionary<TKey, TValue> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return ToOutputDictionary(source, source.Comparer);
        }

        [Pure]
        public static IDictionary<TKey, TValue> ToDictionary<TKey, TValue>(
            IOutputDictionary<TKey, TValue> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            var result = source.ToDictionary(x => x.Key, x => x.Value, source.Comparer);
            return result;
        }
    }
}
