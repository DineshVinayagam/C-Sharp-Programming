using System;
 namespace Question9;
  class Program
  {
    public static void Main(string[] args)
    {
     Console.WriteLine("Enter the speed:");
     double speed=double.Parse(Console.ReadLine());
     System.Console.WriteLine("Enter the time in seconds:");
     double time=double.Parse(Console.ReadLine());
     double distance=speed*time*5/18;
     Console.WriteLine($"The distance is :{distance} meters");
    }
  }
   