using System;
 namespace MergeSort;
  class Program{
    public static void Main(string[] args)
    {
        int[] array={18,19,1,5,7,3,20};
        int l=array.Length;
        MergeSort(array,0,l-1);
        System.Console.WriteLine("The sorted array:");
        for(int m=0;m<l;m++)
        {
          System.Console.Write(array[m]+" ");
        }

      
      
      
      
      static void Merge(int[] array,int left, int mid, int right)
      {
        int i,j,k;
        //right=l-1;
        //mid=(left+right)/2;
        int n1=mid-left+1;
        int n2=right-mid;
        int[] L=new int[n1];
        int[] R=new int[n2];
        for(i=0;i<n1;i++)
        {
          L[i]=array[left+i];
        }
        for(j=0;j<n2;j++)
        {
          R[j]=array[right+1+j];
        }
        i=0;
        j=0;
        k=left;
        while((i<n1)&&(j<n2))
        {
          if(L[i]<=R[j])
          {
            array[k]=L[i];
            i++;
          }
          else{
            array[k]=R[j];
            j++;
          }
          k++;
        }
        while(i<n1)
        {
          array[k]=L[i];
          i++;
          k++;
        }
        while(j<n2)
        {
          array[k]=R[j];
          j++;
          k++;
        }

      }

      static void MergeSort(int[] array,int left,int right)
      {
         if(left<right)
         {
          int mid=(right+left)/2;
          MergeSort(array,left,mid);
          MergeSort(array, mid+1,right);
          Merge(array,left,mid,right);
         }
         
      }
    
    }
  }
