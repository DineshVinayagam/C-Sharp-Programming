using System;
 namespace Question;
  class Program{
    public static void Main(string[] args)
    {
        
        int num=1;
        while(num<=5)
        {
            
            num++;
        }
        int number;
        System.Console.WriteLine("Enter the value to check:");
        bool validate=int.TryParse(Console.ReadLine(),out number);
        while(!validate){
               System.Console.WriteLine("You Entered Invalid input and try again");
               validate=int.TryParse(Console.ReadLine(),out number);
               
        }
        System.Console.WriteLine("you entered a valid input");
    }
  }