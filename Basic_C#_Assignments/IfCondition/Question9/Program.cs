using System;
 namespace Question9;
  class Program
  {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month:");
        string month=Console.ReadLine().ToLower();
        if((month=="january")||(month=="feburary") || (month=="december"))
        {
          System.Console.WriteLine("winter");
        }
        else if((month=="march")||(month=="april")||(month=="may"))
        {
          System.Console.WriteLine("Spring");
        }
        else if((month=="june")|| (month=="july")||(month=="augest"))
        {
          System.Console.WriteLine("Summer");
        }
        else{
          System.Console.WriteLine("Rainfall");
        }
    }
  }