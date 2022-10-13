using System;
 namespace Question1;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first string:");
        string firstString=Console.ReadLine();
        System.Console.WriteLine("Enter the second string");
        string secondString=Console.ReadLine();
        
        string[] firststring=firstString.Split(" ");
        string[] secondstring=secondString.Split(" ");
        //System.Console.WriteLine(firststring[1]);
        if((firststring.Length==secondstring.Length)&&(firstString==secondString))
        {
            System.Console.WriteLine("The length of both strings are equal and both strings are equal");
        }
        else if((firststring.Length==secondstring.Length))
        {
            System.Console.WriteLine("The length of both strings are equal and both strings are not equal");
        }
        else
        {
            System.Console.WriteLine("The length of both string are not equal and both string are not equal");
        }


        
      
    }
  }