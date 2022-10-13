using System;
 namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Date and the Time in the only format yyyy/MM/dd hh:mm:ss AM or PM ");
        DateTime givendate=DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine($"Complete Date:{givendate.ToString()}");
        System.Console.WriteLine($"Short Date:{givendate.ToShortDateString()}");
        System.Console.WriteLine($"Long Date:{givendate.ToLongDateString()}");
        System.Console.WriteLine($"12 Hours Format:{givendate.ToString("dd/MM/yyyy hh:mm:ss tt")}");
        System.Console.WriteLine($"Date Only:{givendate.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Time Only:{givendate.ToString("hh:mm:ss")}");



    }   
} 