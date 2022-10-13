using System;
 namespace Questtion10;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the password:");
        string password=Console.ReadLine();
        
        if(password=="HiTeam")
        {
          System.Console.WriteLine("Right Password");
        }
        else{
            System.Console.WriteLine("Wrong Password");
        }
    }
  }