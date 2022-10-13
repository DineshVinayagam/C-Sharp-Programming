using System;
 namespace Question2;
 class Program
 {
   public static void Main(string[] args)
   {
    System.Console.WriteLine("Enter your age:");
    int age=int.Parse(Console.ReadLine());
    if(age>=18)
    {
        System.Console.WriteLine("Congradulations! You are now eligible for casting your vote");
    }
    else{
        System.Console.WriteLine("You are not eligible to vote");
    }
   }
 }