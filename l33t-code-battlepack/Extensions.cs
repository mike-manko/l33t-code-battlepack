using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l33t_code_battlepack
{
    public static class Extensions
    {
        public static IEnumerable<IEnumerable<T>> GetCombinationsOfLength<T>(this IEnumerable<T> elements, int k)
        {
            return k == 0 ? new[] { Array.Empty<T>() } :
                elements.SelectMany((e, i) => elements.Skip(i + 1).GetCombinationsOfLength(k - 1).Select(c => (new[] { e }).Concat(c)));
        }
    }
}
