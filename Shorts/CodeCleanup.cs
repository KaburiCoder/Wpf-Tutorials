namespace Shorts
{
  public class CodeCleanup
  {
    static string GetName() => "string";
    static bool IsBoolean => true;
    static int GetMaxNumber() => 10;
    static CodeCleanup cleanup
      => new CodeCleanup();

    //static void Main()
    //{
    //  string? str = GetName();
    //  bool boolean = IsBoolean;
    //  int maxNumber = GetMaxNumber();
    //  CodeCleanup? cleanup = new CodeCleanup();
    //  List<string>? list = new List<string>();
    //}
  }
}
