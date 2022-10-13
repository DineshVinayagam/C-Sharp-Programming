using System;
 namespace Question3;
  class Program {
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
        int sum=0;
        System.Console.WriteLine("The sum of the all elements in an array:");
        for(int k=0;k<length;k++)
        {
            sum=sum+array[k];
            
        }
        System.Console.WriteLine(sum);
    }
  }