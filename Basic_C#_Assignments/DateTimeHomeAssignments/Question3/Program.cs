using System;
 namespace Question3;
  class Program
  {

    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Date and the Time in the only format yyyy/MM/dd hh:mm:ss AM or PM ");
        DateTime givendate=DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine($"Year:{givendate.Year}");
        System.Console.WriteLine($"Month:{givendate.Month}");
        System.Console.WriteLine($"Day:{givendate.Day}");
        System.Console.WriteLine($"Hours:{givendate.Hour}");
        System.Console.WriteLine($"Minutes:{givendate.Minute}");
        System.Console.WriteLine($"Seconds:{givendate.Second}");
        System.Console.WriteLine($"Milliseconds:{givendate.Millisecond}");
        
        
    }
    
  }