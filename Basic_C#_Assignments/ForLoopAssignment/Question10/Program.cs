using System;
 namespace Question10;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number to Check:");
        int number=int.Parse(Console.ReadLine());
        int temp=0;
        for(int i=2;i<number/2;i++)
        {
            if(number%i==0)
            {
                temp=1;
                break;
            }
        }
        if(temp==1)
        {
            System.Console.WriteLine($"The {number} is Not Prime Number....");
        }
        else{
            System.Console.WriteLine($"The {number} is a Prime Number.....");
        }
        
    }
  }