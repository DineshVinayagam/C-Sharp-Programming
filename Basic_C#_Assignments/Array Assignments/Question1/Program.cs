using System;
 namespace Question1;
  class Program{
    public static void Main(string[] args)
    {
        string [] values=new string[10];
        System.Console.WriteLine("Input 10 elements in an array:");
        
        for(int i=0;i<10;i++)
        {
            values[i]=Console.ReadLine();
            
        }
        System.Console.WriteLine("Elements in an array are:");
        for(int j=0;j<10;j++)
        {
            System.Console.WriteLine(values[j]);
        }
        

    }
  }