using System;
 namespace Question4;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input the number (Table to be calculated):");
        double number=double.Parse(Console.ReadLine());
        for(int i=1;i<=10;i++)
        {
            double product=number*i;
            System.Console.WriteLine($"{number}X{i}={product}");

        }
    }
  }