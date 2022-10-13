using System;
 namespace Question9;
  class Program{
    public static void Main(string[] args)
    {
        int[,] array1=new int[2,2];
        int[,] array2=new int[2,2];
        int[,] array3=new int[2,2];
        System.Console.WriteLine("Enter the first matrix:");
        int i,j,k;
        for(i=0;i<2;i++)
        {
            for(j=0;j<2;j++)
            {
                array1[i,j]=int.Parse(Console.ReadLine());      
            }
        }
        System.Console.WriteLine("Enter the second matrix:");
        for(i=0;i<2;i++)
        {
            for(j=0;j<2;j++)
            {
                array2[i,j]=int.Parse(Console.ReadLine());
                
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
        System.Console.WriteLine("The second matrix is:");
        for(i=0;i<2;i++)
        {
            for(j=0;j<2;j++)
            {
                System.Console.Write(array2[i,j]+" ");
                
            }System.Console.WriteLine();
        }

        System.Console.WriteLine("The multiplication of the two matrix is:");
        for(i=0;i<2;i++)
        {
            for(j=0;j<2;j++)
            {
                array3[i,j]=0;
                for(k=0;k<2;k++)
                {
                    array3[i,j]+=(array1[i,k]*array2[k,j]);
                }
            }
        }
        for(i=0;i<2;i++)
        {
            for(j=0;j<2;j++)
            {
                System.Console.Write(array3[i,j]+" ");
            }System.Console.WriteLine();
        }
    }
  }