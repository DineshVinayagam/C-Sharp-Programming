using System;
 namespace Question;
  class Program
  {
     public static void Main(string[] args)
     {
        string choice="";
        
        
        do{
            System.Console.WriteLine("Enter the number:");
        long number=long.Parse(Console.ReadLine());
           if(number%2==0){
            System.Console.WriteLine("You entered the even number");
           }
           else{
            System.Console.WriteLine("You entered the odd number");
           }
           System.Console.WriteLine("Do you want to continue:");
           choice=Console.ReadLine();
           
        }while(choice=="yes");
     }
  }