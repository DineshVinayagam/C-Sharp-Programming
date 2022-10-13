using System;
 namespace Question7;
  class Program{
    public static void Main(string[] args)
    {
        for(int i=0;i<4;i++)
        {
            for(int j=4;j>i+1;j--)
            {
                System.Console.Write(" " );
                
            }
             for(int k=0;k<i+1;k++)
            {
                System.Console.Write("* ");
            }System.Console.WriteLine("\r");
        }
    }
  }