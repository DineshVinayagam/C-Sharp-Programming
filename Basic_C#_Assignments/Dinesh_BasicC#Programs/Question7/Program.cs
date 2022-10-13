using System;
 namespace Question
 {
    class Program
    {
        public static void Main(string[] args)
      {
        System.Console.WriteLine("a:");
        float a=float.Parse(Console.ReadLine());
        System.Console.WriteLine("b:");
        float b=float.Parse(Console.ReadLine());
        float a2= a*a;
        float b2= b*b;
        float ab= a*b;
        float output= a2+(2*ab)+b2;
        System.Console.WriteLine($"The output:{output}");
         
      }
    }
 }