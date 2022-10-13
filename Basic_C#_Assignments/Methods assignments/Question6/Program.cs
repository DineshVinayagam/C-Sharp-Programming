using System;
namespace Question6;
 class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number:");
        int number=int.Parse(System.Console.ReadLine());
        Factorial(number);



        void Factorial(int value)
        {
           int factorial=1;
           System.Console.WriteLine($"The factorial of the {value} is ");
           for(int i=1;i<=value;i++)
           {
            factorial=factorial*i;
           
           }
            System.Console.WriteLine(factorial);
          
        }

    }
 }