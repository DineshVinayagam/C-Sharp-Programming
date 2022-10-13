using System;
 namespace Question;
  class Program{
    public static void Main(string[] args)
    {
       
        System.Console.WriteLine("Enter the Elements in an array");
        int[,] array=new int[3,3];
        for(int i=0;i<3;i++)
        {
          for(int j=0;j<3;j++)
          {
            array[i,j]=int.Parse(Console.ReadLine());
            
          }
            
        }
        for(int k=0;k<3;k++)
        {
           for(int l=0;l<3;l++)
           {
            System.Console.Write(array[k,l]+" ");
           }System.Console.WriteLine();
        }

        
        
    }
  }
 
    
 