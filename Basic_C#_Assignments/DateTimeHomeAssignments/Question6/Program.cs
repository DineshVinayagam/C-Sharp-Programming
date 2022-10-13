using System;
 namespace Question6;
  class Program{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Now;
        DateTime newdate=date.AddDays(40);
        System.Console.WriteLine($"Current Date and Time:{date}");
        System.Console.WriteLine($"After 40 Days the Date is:{newdate} and the Day of the week is {newdate:dddd}");
    }
  }