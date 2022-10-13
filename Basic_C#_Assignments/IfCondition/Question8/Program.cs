using System;
 namespace Question8;
  class Program
  {
     public static void Main(string[] args)
     {
        System.Console.WriteLine("Enter the sugar level:");
        int sugarlevel=int.Parse(Console.ReadLine());
        if(sugarlevel<90)
        {
            System.Console.WriteLine("Low sugar");
        }
        else if((sugarlevel>=90)&&(sugarlevel<130))
        {
            System.Console.WriteLine("Normal sugar");
        }
        else if((sugarlevel>=130)&&(sugarlevel<140))
        {
           System.Console.WriteLine("Medium sugar");
        }
        else if((sugarlevel>=140)&&(sugarlevel<170))
        {
            System.Console.WriteLine("High Sugar Try to reduce it from now");
        }
        else
        {
            System.Console.WriteLine("You are a very high sugar patient...");
        }

        
     }
  }