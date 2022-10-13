using System;
 namespace Question3;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number:");
        int number1=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the second number:");
        int number2=int.Parse(Console.ReadLine());
        Swap(number1,number2);


        void Swap(int value1,int value2)
        {
           int temp;
           temp=value1;
           value1=value2;
           value2=temp;
           System.Console.WriteLine($"The first number is:{value1}");
           System.Console.WriteLine($"The second number is:{value2}");
           
        }
        
    }
  }