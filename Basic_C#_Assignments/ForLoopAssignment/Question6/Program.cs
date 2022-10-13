using System;
 namespace Question6;
  class Program{
    public static void Main(string[] args)
    {
        for(int i=0;i<4;i++)
        {
            for(int j=0;j<i+1;j++)
            {
                System.Console.Write(" * " );
                
            }System.Console.WriteLine("\r");
           
        }
    }
  }