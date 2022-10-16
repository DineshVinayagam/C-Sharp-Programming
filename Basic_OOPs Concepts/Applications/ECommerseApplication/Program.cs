using System;
 namespace ECommerseApplication;
  class Program{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        Operations.MainMenu();
        //Operations.AddDefaultData();
        Files.WriteFile();
    }
  }