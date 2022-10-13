using System;
 namespace Questtion;
  class Program
  {
    public static void Main(string[] args)
    {
       int value=0;
       int value1=0;
       System.Console.WriteLine("The Even values are:");
       
        
       while(value<=100)
       {
        
        if(value%2==0)
        {
            
            System.Console.WriteLine(value);
        } value++;
       }
       System.Console.WriteLine("The odd values are:");
      while(value1<=100)
        {
        if(value1%2!=0)
        {
           
            System.Console.WriteLine(value1);
        }
        value1++;
       }
       
       
    }
  }