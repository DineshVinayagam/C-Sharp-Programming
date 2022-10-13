using System;
 namespace Question4;
  class Program{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2000,11,07);
        System.Console.WriteLine($"The Day of the week of{date:d} is {date.DayOfWeek}");
    }
  }