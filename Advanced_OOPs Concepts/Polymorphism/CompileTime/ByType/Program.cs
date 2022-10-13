using System;
 namespace ByType;
  class Program{


    static void Display(int number)
    {
        System.Console.WriteLine("Int type:"+number);
    }
    static void Display(string name)
    {
        System.Console.WriteLine("String Type:"+name);
    }
    public static void Main(string[] args)
    {
       Display(100);
       Display("Dinesh");

    }
  }