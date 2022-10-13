using System;
 namespace Question;
  class Program{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Input the number of terms:");
       int n=int.Parse(Console.ReadLine());
       for (int i=1;i<=n;i++)
       {
        double cube=(double) i*i*i;
        System.Console.WriteLine($"The Number is:{i} and cube of {i} is:{cube}");
       }

        
    }
  }
