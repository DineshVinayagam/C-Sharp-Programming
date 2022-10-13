using System;
 namespace Question
 {
    class Program
    {
        public static void Main(string[] args)
      {
       Console.WriteLine("Enter the price:");
       double price= double.Parse(Console.ReadLine());
       double total= (price*0.18)+price;
       Console.WriteLine($"The Total:{total}");

      } 

    }
 }