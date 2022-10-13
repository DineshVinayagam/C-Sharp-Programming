using System;
 namespace Question1;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Input string:");
        string mainString=Console.ReadLine();
        string[] chararray=mainString.Split(" ");
        System.Console.WriteLine("The words count in the String is :"+chararray.Length);
      
    }
  }