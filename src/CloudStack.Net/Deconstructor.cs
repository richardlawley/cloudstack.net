using System;
using System.Collections.Generic;
using System.Linq;

namespace CloudStack.Net
{
    internal static class Deconstructor
    {
        internal static void Deconstruct<K, V>(this KeyValuePair<K, V> item, out K key, out V value)
        {
            key = item.Key;
            value = item.Value;
        }
    }
}