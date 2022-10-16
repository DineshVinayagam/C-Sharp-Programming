using System;
 namespace OnlineMedicalApplication;
  class Program{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        Operations.DefaultUser();
         Operations.MainMenu();
         Files.WriteFile();

    }
  }
