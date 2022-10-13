using System;
using System.Linq;
 namespace Question12;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number String:");
        string number=Console.ReadLine();
        var splitednumber=number.Split(" ");
        var newnumber=splitednumber.Select(int.Parse).ToArray();
       System.Console.WriteLine($"The maximum number in a string{newnumber.Max()}"); 
       System.Console.WriteLine($"The minimum number in a string {newnumber.Min()}");
    }
  }