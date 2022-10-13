using System;
 namespace Question5;
  class Program{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2000,12,31);
        for(int i=0;i<=8;i++)
        {
            DateTime newdate=date.AddYears(i);
            System.Console.WriteLine($"{newdate:d}  Day{newdate.DayOfYear} of {newdate.Year}");
        }
    }
  }