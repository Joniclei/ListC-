using System;
namespace Listando
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> test = new List<string>();

      test.Add("teste one");
      test.Add("bgora que e 1");
      test.Add("ago2");
      test.Add("kkkdgora que e 1");
      test.Add("bbo3");

      foreach (string x in test)
      {
        Console.WriteLine(x);
      }
      Console.WriteLine(test.Count);

      int b = test.FindLastIndex(x => x[0] == 'b');

      Console.WriteLine(b);

      List<string> test2 = test.FindAll(x => x.Length == 4);

      Console.WriteLine("=============");

      foreach (string p in test2)
      {
        Console.WriteLine(p);
      }

      test.Remove("bbo3");
      test.Remove("teste one");
      test.Remove("bgora que e 1");
      test.Remove("ago2");
      test.Add("dg ora que e 1");

      foreach(string k in test){
      Console.WriteLine(k);
      }

    }

  }
}
