
namespace System.Collections.Generic;

internal static class CollectionExtensions
{
    const int ArrayMaxLength = 0X7FFFFFC7;

    public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> kvp, out TKey key, out TValue value)
    {
        key = kvp.Key;
        value = kvp.Value;
    }

    public static bool Remove<TKey, TValue>(this SortedDictionary<TKey, TValue> dict, TKey key, out TValue value)
    {
        if (dict.TryGetValue(key, out value))
        {
            return dict.Remove(key);
        }
        return false;
    }

    public static bool Remove<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, out TValue value)
    {
        if (dict.TryGetValue(key, out value))
        {
            return dict.Remove(key);
        }
        return false;
    }
}

