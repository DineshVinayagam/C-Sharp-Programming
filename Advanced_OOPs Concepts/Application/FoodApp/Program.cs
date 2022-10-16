using System;
 namespace FoodApp;
  class Program{
    public static void Main(string[] args)
    {
        
        Files.Create();
        Files.ReadFile();
        Operations.MainMenu();
        Files.WriteFiles();
    }
  }