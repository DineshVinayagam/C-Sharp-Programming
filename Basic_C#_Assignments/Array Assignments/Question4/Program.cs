using System;
 namespace Question4;
  class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the length of the array:");
        int length= int.Parse(Console.ReadLine());
        int [] array=new int[length];
        System.Console.WriteLine("Input the elements in an array:");
        for(int i=0;i<length;i++)
        {
            array[i]=int.Parse(Console.ReadLine());
           
            
        }
        System.Console.WriteLine("The entered elements in an array:");
        for(int j=0;j<length;j++)
        {
            System.Console.WriteLine(array[j]);
        }
        int max=array[0];
        System.Console.WriteLine("The maximum value in an array");
        for(int k=0;k<length;k++)
        {
            if(array[k]>max)
            {
                max=array[k];
            }
        }
        System.Console.WriteLine(max);
        int min=array[0];
        System.Console.WriteLine("The minimum value in an array");
        for(int l=0;l<length;l++)
        {
            if(array[l]<min)
            {
                min=array[l];
            }
        
        }
        System.Console.WriteLine(min);
    }
}