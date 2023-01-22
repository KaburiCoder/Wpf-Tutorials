namespace Shorts
{
  public class ValueTuplePractice
  {
    /*      
     *      
      ▣ 선언방법 1
       ▶ (string name, int age) = ("홍길동", 23);

      ▣ 선언방법 2
       ▶ var t = (name: "홍길동", age: 23);

      ▣ 선언방법 3
       ▶ string name = "홍길동";
          int age = 23;
          var t = (name, age);
    */

    static NameAgeStruct GetNameAndAge()
    {
      return new NameAgeStruct("홍길동", 23);
    }

    // structure
    struct NameAgeStruct
    {
      public NameAgeStruct(string name, int age)
      {
        Name = name;
        Age = age;
      }

      public string Name { get; set; }
      public int Age { get; set; }
    }

    // record (c# 9.0)
    record NameAgeRecord(string Name, int Age);












    //public static void Main()
    //{
    //  NameAgeStruct myStruct = GetNameAndAge();

    //  Console.WriteLine($"name: {myStruct.Name}, " +
    //                     $"age: {myStruct.Age}");
    //}












    //public ValueTuplePractice()
    //{
    //  var tuple = GetNameAndAge();

    //  string name = tuple.Item1;
    //  int age = tuple.Item2;

    //  Console.WriteLine($"name: {name}, age: {age}");
    //}



    //public ValueTuplePractice()
    //{
    //  var vTuple = GetNameAndAge();

    //  string name = vTuple.name;
    //  int age = vTuple.age;

    //  Console.WriteLine($"name: {name}, age: {age}");
    //}




  }
}
