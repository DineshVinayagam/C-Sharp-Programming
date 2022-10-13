using System;
 namespace Question10;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the user name:");
        string username=Console.ReadLine();
        System.Console.WriteLine("Enter the pass word");
        string password=Console.ReadLine();
        if((username=="user")&& (password=="pass"))
        {
            System.Console.WriteLine("You Entered pass word sucessfully.....");
        }
    }
  }