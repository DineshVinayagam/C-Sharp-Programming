using System;
 namespace Question11;
  class Program{
    public static void Main(string[] args)
    {
        DateTime today=DateTime.Today;
        System.Console.WriteLine($"Today is:{today.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine("The Twelve Months from today:");
        for(int i=0;i<12;i++)
        {
            System.Console.WriteLine($"{today.ToString("MMMM")}");
            today=today.AddMonths(1);
        }
    }
  }