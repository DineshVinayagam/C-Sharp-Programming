using System;
 namespace Question;
  class Program{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter the number:");
       int number=int.Parse(Console.ReadLine());
       int digit;
       int sum=0;
       while(number>0)
       {
        digit=number%10;
         sum=sum+digit;
         number=number/10;
       }
       System.Console.WriteLine("Sum of digits is:"+sum);
        
            
         
    } 
  }