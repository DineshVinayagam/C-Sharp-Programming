using System;
 namespace Question
 {
   class Program
   { 
    public static void Main(string[] args)
   {
        Console.WriteLine("Chemistry:");
        int chemMarks=int.Parse(Console.ReadLine());
        Console.WriteLine("Physics:");
        int phyMarks=int.Parse(Console.ReadLine());
        Console.WriteLine("Maths:");
        int mathMarks=int.Parse(Console.ReadLine());
        float sum=chemMarks+phyMarks+mathMarks;
        float percentage=sum/3;
        Console.WriteLine($"Sum={sum}");
        Console.WriteLine($"Percentage={percentage}");
    
   }
     
   } 
 }