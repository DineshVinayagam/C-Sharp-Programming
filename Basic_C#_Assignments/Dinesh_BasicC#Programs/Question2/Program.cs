using System;
namespace System
{
    class Program
    {
        public static void Main(string[] args)
         { 
            Console.WriteLine("Enter the first Number:");
            float num1= float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number:");
            float num2= float.Parse(Console.ReadLine());
            float sum= num1+num2;
            float sub= num1-num2;
            float mul= num1*num2;
            float div= num1/num2;
            float mod= num1%num2;
            Console.WriteLine($"{num1}+{num2}={sum}");
            Console.WriteLine($"{num1}-{num2}={sub}");
            Console.WriteLine($"{num1}x{num2}={mul}");
            Console.WriteLine($"{num1}/{num2}={div}");
            Console.WriteLine($"{num1}%{num2}={mod}");

        
         }
    }
}