using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitRecognition
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> list)
        {
            var r = new Random((int)DateTime.Now.Ticks);
            return list.Select(x => new { Number = r.Next(), Item = x }).OrderBy(x => x.Number).Select(x => x.Item);
        }
    }
}
