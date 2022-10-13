using System;
 namespace Question2;
 class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input the number of elements stored in the array:");
        int length= int.Parse(Console.ReadLine());
        int[] array=new int[length];
        System.Console.WriteLine("Input The elements in an array:");
        
        for(int i=0;i<length;i++)
        {
            array[i]=int.Parse(Console.ReadLine());
            
            
        }
        System.Console.WriteLine("The elements in an array:");
        for(int k=0;k<length;k++)
        {
            System.Console.WriteLine(array[k]);
        }
        System.Console.WriteLine("The reversed array");
        for(int j=length-1;j>=0;j--)
        {
            System.Console.WriteLine(array[j]);
        }

    
    }
 }