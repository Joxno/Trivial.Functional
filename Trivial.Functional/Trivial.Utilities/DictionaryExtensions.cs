using System.Collections.Concurrent;
using System.Collections.Generic;
using Trivial.Functional;

namespace Trivial.Utilities
{
    public static class DictionaryExtensions
    {
        public static Maybe<TValue> Retrieve<TKey, TValue>(this Dictionary<TKey, TValue> Dictionary, TKey Key) =>
            Dictionary.TryGetValue(Key, out var t_Value)
                ? t_Value
                : null;

        public static Maybe<TValue> Retrieve<TKey, TValue>(this ConcurrentDictionary<TKey, TValue> Dictionary, TKey Key) =>
            Dictionary.TryGetValue(Key, out var t_Value)
                ? t_Value
                : null;

        public static Dictionary<TKey, TValue> Merge<TKey, TValue>(this Dictionary<TKey, TValue> Dictionary, Dictionary<TKey, TValue> Other)
        {
            var t_Merged = new Dictionary<TKey, TValue>(Dictionary);
            
            foreach(var t_KV in Dictionary)
                t_Merged[t_KV.Key] = t_KV.Value;
            foreach(var t_KV in Other)
                t_Merged[t_KV.Key] = t_KV.Value;

            return t_Merged;
        }
    }
}