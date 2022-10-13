using System;
 namespace Question9;
  class Program{
    public static void Main(string[] args)
    {
        for(int i=1995; i<=2016;i++)
        {
            if(DateTime.IsLeapYear(i))
            {
                System.Console.WriteLine($"{i} is a leap year");
                DateTime leapyear=new DateTime(i,2,29);
                DateTime nextyear=leapyear.AddYears(1);
                System.Console.WriteLine($"One year after the leap year{leapyear.ToString("d")} is {nextyear.ToString("d")} ");
            }
        }
    }
  }