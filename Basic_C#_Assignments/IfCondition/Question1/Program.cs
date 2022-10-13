using System;
 namespace Question1;
  class Program
  {
    public static void Main(string[] args)
    {
     System.Console.WriteLine("enter the input to test:");
     int value=int.Parse(Console.ReadLine());
     if (value%2==0)
     {
        System.Console.WriteLine("The number is even number");
     }
     else{
        System.Console.WriteLine("The number is odd number");
     }
     
    }
  }