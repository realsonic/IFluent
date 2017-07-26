using System.Collections.Generic;
using System.Linq;

namespace IFluent.Движок
{
    public static class EnumerableExt
    {
        public static string Join(this IEnumerable<string> enumerable, string separator = "")
        {
            return string.Join(separator, enumerable.ToArray());
        }
    }
}
