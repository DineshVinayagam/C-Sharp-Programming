using System;


namespace OnlineGrocery
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //Process.StartEvent();
           Files.Create();
           Files.ReadFile();
           Process.AddDefaultData();
           Files.WriteFile();

        }
    }
}