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
        //int max=array[0];
        Array.Sort(array);
        System.Console.WriteLine("Elements of array in ascending order:");
        foreach (int value in array)
        {
            System.Console.WriteLine(value); 
        }
        Array.Reverse(array);
        System.Console.WriteLine("Elements of array in decending order:");
        foreach(int value1 in array)
        {
            System.Console.WriteLine(value1);
        }
    }
}