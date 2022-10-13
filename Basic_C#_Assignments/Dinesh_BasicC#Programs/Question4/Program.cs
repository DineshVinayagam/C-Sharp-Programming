using System;
   namespace Question4
   {
      class Program
      {
         public static void Main(string[] args)
         {
         Console.WriteLine("Enter the radius:");
         float radius=float.Parse(Console.ReadLine());
         Console.WriteLine("Enter the height:");
         float height= float.Parse(Console.ReadLine());
         double r2= radius*radius;
         double volume= (r2*3.14)*height;
         Console.WriteLine($"The volume is:{volume}");
         }

      }
   }