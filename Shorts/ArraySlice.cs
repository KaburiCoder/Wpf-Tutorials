using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shorts
{
  public class ArraySlice
  {
    public ArraySlice()
    {

      var array = new string[] 
      { "0. apple", "1. banana", "2. grape", "3. coconut", "4. kiwi" };

      string[] slice1 = array[1..3];  // 인덱스 1 부터 인덱스 3(미포함)이전 까지
      string[] slice2 = array[1..^1]; // 인덱스 1 부터 뒤에서 1번째 인덱스(미포함)이전 까지
      string[] slice3 = array[..3];   // 인덱스 3(미포함)이전 까지 => 앞에서 3개
      string[] slice4 = array[3..];   // 인덱스 3 부터 모두
         

      Console.WriteLine($"1..3  : {string.Join(", ", slice1)}");
      Console.WriteLine($"1..^1 : {string.Join(", ", slice2)}");
      Console.WriteLine($"..3   : {string.Join(", ", slice3)}");
      Console.WriteLine($"3..   : {string.Join(", ", slice4)}");
     
      string[] deepCopy = array[..];    // 배열 전체 DeepCopy 복사
      deepCopy[1] = "1. 바나나";

      Console.WriteLine("---- 깊은 복사 ----");     
      Console.WriteLine($"deepCopy : {string.Join(", ", deepCopy)}");
      Console.WriteLine($"array : {string.Join(", ", array)}");

      Console.WriteLine("---- 얕은 복사 ----");
      string[] shallowCopy = array;
      shallowCopy[1] = "1. 바나나";
      Console.WriteLine(new string('-', 20));
      Console.WriteLine($"shallowCopy : {string.Join(", ", shallowCopy)}");
      Console.WriteLine($"array : {string.Join(", ", array)}");
    }
  }
}






//var item = list.Skip(1).Take(4);
//var item2 = list.GetRange(1, 4);
//var array = new string[] { "apple", "banana", "grape", "coconut", "kiwi" };

//var arr = array[3..5];