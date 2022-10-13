using System;
namespace Question10;
 class Program{
    public static void Main(string[] args)
    {
        int[,] array1=new int[2,2];
        int[,] array2=new int[2,2];
        int i,j;
        System.Console.WriteLine("Enter the first matrix");
        for(i=0;i<2;i++)
        {
            for(j=0;j<2;j++)
            {
                array1[i,j]=int.Parse(Console.ReadLine());
                
            }
        }
        System.Console.WriteLine("The first matrix is:");
        for(i=0;i<2;i++)
        {
            for(j=0;j<2;j++)
            {
                System.Console.Write(array1[i,j]+" ");
                
            }System.Console.WriteLine();
        }
        System.Console.WriteLine("The transpose matrix is:");
         for(i=0;i<2;i++)
        {
            for(j=0;j<2;j++)
            {
                System.Console.Write(array1[j,i]+" ");
                
            }System.Console.WriteLine();
        }
    }
 }