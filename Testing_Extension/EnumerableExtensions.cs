using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Extension
{
    internal static class EnumerableExtensions
    {
        public static T MaxOrDefault<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            if (source == null || !source.Any()) return default;

            return source.Max();
        }
    }
}
