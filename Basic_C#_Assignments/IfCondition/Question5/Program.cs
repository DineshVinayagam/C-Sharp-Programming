using System;
 namespace Question5;
  class Program{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter the Physics marks:");
       float physics=float.Parse(Console.ReadLine());
       System.Console.WriteLine("Enter the Chemistry marks:");
       float chemistry=float.Parse (Console.ReadLine());
       System.Console.WriteLine("Enter the Maths marks:");
       float maths=float.Parse(Console.ReadLine());
       float average=(physics+chemistry+maths)/3;
       if(average>=75)
       {
        System.Console.WriteLine("The candidate is Eligible for admission");
        
       }
       else
       {
        System.Console.WriteLine("The candidate is not Eligible for admission");
       }
       
       
    }
  }