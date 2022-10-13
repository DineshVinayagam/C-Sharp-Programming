using System;
 namespace Question5;
 class Program
 {
   public static void Main(string[] args)
   {
    System.Console.WriteLine("Input the number of terms:");
    long number=long.Parse(Console.ReadLine());
    
    long sum=0;
    for(long i=1;i<=number;i++)
    {
        
      
      
      if(i%2!=0)
      {
        System.Console.WriteLine(i);
        sum=sum+i;
      
      }
      
    }System.Console.WriteLine("The sum of the odd number: "+sum);

   }
   
   
 }