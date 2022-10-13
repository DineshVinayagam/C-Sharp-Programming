using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 namespace SortingAlgorithm;
  class Program
  { 
    public static void Main(string[] args)
    {
      System.Console.WriteLine("Enter the option: 1.BubbleSort 2.InsertionSort 3.SelectionSort ");
      int option=int.Parse(Console.ReadLine());
      switch(option)
      {
        case 1:
        {
          BubbleSort();
          break;
        }
        case 2:
        {
          InsertionSort();
          break;
        }
        case 3:
        {
          SelectionSort();
          break;
        }
        
      }
      
      



      void BubbleSort()
      {
        int[] array={18,19,1,5,7,3,20};
      int i,j;
      int temp=0;
      for(i=0;i<array.Length-1;i++)
      {
        for(j=0;j<array.Length-1;j++)
        {
          if(array[j]>array[j+1])
          {
            temp=array[j+1];
            array[j+1]=array[j];
            array[j]=temp;

          }
        }

      }
      System.Console.WriteLine("The sorted array is:");
      for(int k=0;k<array.Length;k++)
      {
        System.Console.Write(array[k]+" ");  
      }
      }


      void InsertionSort()
      {
        int[] array={18,19,1,5,7,3,20};
        int i,j;
        int temp=0;
        for(i=1;i<array.Length;i++)
        {
          temp=array[i];
          j=i-1;
          while((j>=0)&&(array[j]>temp))
          {
            array[j+1]=array[j];
            j=j-1;
          }
          array[j+1]=temp;
        }
        System.Console.WriteLine("The sorted array is:");
        for(int k=0;k<array.Length;k++)
        {
           System.Console.Write(array[k]+" ");
        }
      }


      void SelectionSort()
      {
         int[] array={18,19,1,5,7,3,20};
         int i,j,smallest;
         int temp;
         for(i=0;i<array.Length-1;i++)
         {
          smallest=i;
          for(j=i+1;j<array.Length;j++)
          {
            if(array[j]<array[smallest])
            {
              smallest=j;
            }
            
          }
          temp=array[smallest];
          array[smallest]=array[i];
          array[i]=temp;
          
         }
         System.Console.WriteLine("The sorted array is:");
          for(int k=0;k<array.Length;k++)
          {
              System.Console.Write(array[k]+" ");
          }
      }
      
      
     
    }
  }
