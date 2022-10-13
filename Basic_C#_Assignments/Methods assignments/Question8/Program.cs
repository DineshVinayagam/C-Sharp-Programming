using System;
 namespace Question8;
  class Program
  {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first mark:");
        int mark1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second mark:");
        int mark2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the third mark");
        int mark3=int.Parse(Console.ReadLine());
        Percentage(mark1,mark2,mark3);
        




        void Percentage(int value1,int value2,int value3)
        {
           int sum=value1+value2+value3;
           int average=sum/3;
           System.Console.WriteLine($"Mark1:{value1}");
           System.Console.WriteLine($"Mark2:{value2}");
           System.Console.WriteLine($"Mark3:{value3}");
           System.Console.WriteLine($"The percentage is:{average}%");
        }
        
    }
  }