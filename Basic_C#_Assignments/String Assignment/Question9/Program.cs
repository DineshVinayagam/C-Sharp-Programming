using System;
 namespace Question9;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string:");
        string word=Console.ReadLine();
        System.Console.WriteLine("Enter the sub string:");
        string subword=Console.ReadLine();
        if(word.Contains(subword))
        {
            System.Console.WriteLine("The sub string is present in the String:");
        }
        else{
            System.Console.WriteLine("The substring is not present in the string");
        }
    }
  }