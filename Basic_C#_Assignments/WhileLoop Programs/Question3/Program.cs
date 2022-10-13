using System;
 namespace Question;
 class Program{
    public static void Main(string[] args)
    {
        int n1=0;
        int n2=1;
        int n3;
        int i=3;
        System.Console.WriteLine("Input the number of terms:");
        int number=int.Parse(Console.ReadLine());
         System.Console.WriteLine($"The fibanocci series of {number} are: ");
         System.Console.WriteLine(n1);
         System.Console.WriteLine(n2);
        while(i<=number)
        {
          n3=n1+n2;
          n1=n2;
          n2=n3;
          System.Console.WriteLine(n3);
          i++;


        }
       
        
    }
 }