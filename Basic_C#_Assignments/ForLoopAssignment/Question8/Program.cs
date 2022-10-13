using System;
 namespace Question8;
  class Program{
    public static void Main(string[] args)
    {
        int l=1;
        for(int i=0;i<4;i++)
        {
            for(int j=4;j>i+1;j--)
            {
                System.Console.Write(" " );
                
            }
             for(int k=0;k<i+1;k++)
            {   
                System.Console.Write(l+" ");
                l++;
            }System.Console.WriteLine("\r");
        }
    }
  }