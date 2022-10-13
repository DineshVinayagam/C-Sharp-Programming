using System;
 namespace Question;
  class Program{
    public static void Main(string[] args)
    {
       
        
        int[,] array1=new int[2,2];
        int[,] array2=new int[2,2];
        int[,] array3=new int[2,2];
        int i,j,k,l,m,n,o,p;
        System.Console.WriteLine("Enter the Elements of a first matrix");
        for(i=0;i<2;i++)
        {
          for(j=0;j<2;j++)
          {
            array1[i,j]=int.Parse(Console.ReadLine());
            
          }
        
        }
        System.Console.WriteLine("Enter the Elements of a second matrix");
        for( k=0;k<2;k++)
        {
          for( l=0;l<2;l++)
          {
            array2[k,l]=int.Parse(Console.ReadLine());
            
          }
        }

        for(m=0;m<2;m++)
        {
           for(n=0;n<2;n++)
           {
            System.Console.Write(array1[m,n]+" ");
           }System.Console.WriteLine();
        }
        for( o=0;o<2;o++)
        {
            for( p=0;p<2;p++)
            {
                System.Console.Write(array2[o,p]+" ");
            }System.Console.WriteLine();
        }
        for(i=0;i<2;i++)
        {
          for(j=0;j<2;j++)
          {
            array3[i,j]=array1[i,j]+array2[i,j];
          }
        }
        System.Console.WriteLine("The addition matrix is:");
        for(i=0;i<2;i++)
        {
          for(j=0;j<2;j++)
          {
            System.Console.Write(array3[i,j]+" ");
          }System.Console.WriteLine();
        }
        


        
        
    }
  }
 
    
 