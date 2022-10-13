using System;
 namespace QuickSort;
  class Program{
    public static void Main(string[] args)
    {

        int[] array={18,19,1,5,7,3,20};
        int i;
        QSort(array,0,5);
        System.Console.WriteLine("The sorted array is:");
        for(i=0;i<array.Length;i++)
        {
            System.Console.Write(array[i]+" ");
        }
      
      
      
      
      int  QuickSort1(int[] array,int leftelement,int rightelement)
       {
       int pivot;
       pivot=array[leftelement];
       while(true)
       {
        while(array[leftelement]<pivot)
        {
          leftelement++;
        }
        while(array[rightelement]>pivot)
        {
          rightelement--;
        }
        if(leftelement<rightelement)
        {
          int temp=array[rightelement];
          array[rightelement]=array[leftelement];
          array[leftelement]=temp;
        }
        else{
          return rightelement;
        }
       }
     }

      void QSort(int[] array,int leftelement,int rightelement)
       {
      
        if(leftelement<rightelement)
        {
          int pivot=QuickSort1(array,leftelement,rightelement);
          if(pivot>1)
          {
            QSort(array,leftelement,pivot-1);
          }
          if(pivot+1<rightelement)
          {
            QSort(array,pivot+1,rightelement);
          }

        }
       }

          
    
    }
  }