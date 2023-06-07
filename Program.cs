using System;
namespace Listando
{
  class Program
  {
    public static void Main(string[]args)
    {
      List <string> test = new List<string>();

      test.Add("teste one");
      test.Add("bgora que e 1");
      test.Add("agora e o 2");
      test.Add("dgora que e 1");
      test.Add("bbora e o 2");

      foreach(string x in test){
        Console.WriteLine(x);
      }
      Console.WriteLine(test.Count);

      int b = test.FindLastIndex(x => x[0] == 'b');

      Console.WriteLine(b);

    }
  }
}
