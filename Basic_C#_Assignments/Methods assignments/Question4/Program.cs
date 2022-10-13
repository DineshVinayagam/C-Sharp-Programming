using System;
 namespace Question4;
  class Program {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of series:");
        int number=int.Parse(Console.ReadLine());
        Fibonacci(number);



        void Fibonacci(int value)
        {
           int n1=0;
           int n2=1;
           int n3;
           System.Console.WriteLine($"The fibonacci series is:{n1}\n{n2}\n");
           for(int i=0;i<=value;i++)
           {
            n3=n1+n2;
            n1=n2;
            n2=n3;
            System.Console.WriteLine(n3);
            
           }
        }
        
    }
  }
    