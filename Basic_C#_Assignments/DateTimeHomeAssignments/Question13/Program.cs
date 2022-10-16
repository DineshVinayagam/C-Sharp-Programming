using System;
 namespace Question13
 {
    class Program
    {
       public static void Main(string[] args)
       {
        System.Console.WriteLine("Enter the Day of the Month:");
        int day=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Month Of the Year");
        int month=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Year:");
        int year=int.Parse(Console.ReadLine());

        DateTime date=new DateTime(year,month,day);
        System.Console.WriteLine($"The Formatted date is : {date.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"The Last Day of the week is : {LastDayOfWeek(date).ToString("dd/MM/yyyy")}");
        
       }
       public static DateTime LastDayOfWeek (DateTime date)
       {
        var cul=System.Threading.Thread.CurrentThread.CurrentCulture;
        var remainingDay=date.DayOfWeek-cul.DateTimeFormat.FirstDayOfWeek;

        if(remainingDay<0)
        {
            remainingDay=remainingDay+7;
        }
        return date.AddDays(remainingDay).Date;
       }
    }
 }