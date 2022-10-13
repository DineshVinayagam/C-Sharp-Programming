using System;
using System.Globalization;
 namespace Question12;
  class Program{
    public static void Main(string[] args)
    {
        int month,year;
         System.Console.WriteLine("Enter the month of the year in number 1,2,3.....");
         month=int.Parse(Console.ReadLine());
         System.Console.WriteLine("Enter the year:");
         year=int.Parse(Console.ReadLine());
         DateTimeFormatInfo dinfo=new DateTimeFormatInfo();
         string monthNumber=dinfo.GetMonthName(month);
         int numberofDays=DateTime.DaysInMonth(year,month);
         System.Console.WriteLine($"The Number of days in the {monthNumber} month is:{numberofDays}Days");

         
         
    }
  }