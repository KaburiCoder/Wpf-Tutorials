using System.Collections.Generic;
using System.Linq;

namespace Shorts.Extensions
{
  public static class IEnumableExtension
  {
    public static T? Get<T>(this IEnumerable<T>? value, int index)
    {
      if (value == null) return default;
      if (index < 0) return default;
            
      return value.Count() > index
        ? value.ElementAt(index)
        : default;
    }
  }
}
