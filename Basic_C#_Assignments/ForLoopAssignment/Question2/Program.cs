using System;
 namespace Question2;
  class Program{
    public static void Main(string[] args)
    {   
    System.Console.WriteLine("Enter the 10 numbers:");
     int sum=0;
    
    for (int i=1;i<=10;i++)
    {
        
        int number=int.Parse(Console.ReadLine());
        sum=sum+number;
        
        
    
    }
    double average= sum/10;
    System.Console.WriteLine("The sum is :"+sum);
    System.Console.WriteLine("The average is :"+average);
    

    }

    }
  