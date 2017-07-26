using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFluent
{
    public static class EnumerableExt
    {
        public static string Join(this IEnumerable<string> enumerable, string separator = "")
        {
            return string.Join(separator, enumerable.ToArray());
        }
    }
}
