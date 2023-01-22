using Shorts.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shorts
{
  public class ArrayGet
  {
    public ArrayGet()
    {
      var array = new string[]
      { "0. apple", "1. banana", "2. grape", "3. coconut", "4. kiwi" };

      string? value = array.Get(3);
      string? outOfIndex = array.Get(5);

      Console.WriteLine($"value : {value}");
      if (outOfIndex != null)
      {
        Console.WriteLine($"outOfIndex : {outOfIndex}");
      }

      var ints = new List<int>() { 0, 1, 2, 3, 4 };

      int? intValue = ints.Get(3);
      int? intOutOfIndex = ints.Get(5);

      Console.WriteLine($"intValue : {intValue}");
      Console.WriteLine($"intOutOfIndex : {intOutOfIndex}");
    }
  }
}
