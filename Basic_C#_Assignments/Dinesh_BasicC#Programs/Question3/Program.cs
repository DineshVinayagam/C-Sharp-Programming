using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
         {
            Console.WriteLine("Enter the amount of Celsius:");
            float celsius=float.Parse(Console.ReadLine());
            float kelvin= celsius+273;
            //float num1=9;
            //float num2=5;
            //float div= num1/num2;
            float fahrenheit=celsius*9/5+32;
            Console.WriteLine($"Kelvin={kelvin}");
            Console.WriteLine($"Fahrenheit={fahrenheit}");
        
         }

    }

}
