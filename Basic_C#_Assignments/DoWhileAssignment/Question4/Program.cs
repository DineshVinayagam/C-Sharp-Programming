using System;
 namespace Question4;
  class Program{
    public static void Main(string[] args)
    {   
        int i=0;
        do{
           i++;
          }while(i<=10);
          int number;
          System.Console.WriteLine("Enter the number:");
         bool validate=int.TryParse(Console.ReadLine(),out number);
         
        while(!validate)
            {   System.Console.WriteLine("you entered invalid input:");
                System.Console.WriteLine("enter the valid input:");
                validate=int.TryParse(Console.ReadLine(),out number);
                
            }
            System.Console.WriteLine($"You entered number is:{number}");
         
        
    }
  }
  