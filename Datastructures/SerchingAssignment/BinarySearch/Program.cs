using System;
 namespace BinarySearch;
  class Program
  {
    public static void Main(string[] args)
    {
        
        System.Console.WriteLine("Enter the option 1.Value Binary Search 2.Character Binary Search 3.String Binary Search");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
          case 1:
          {
            ValueSearch();
            break;
          }
          case 2:
          {
            CharSearch();
            break;
          }
          case 3:
          {
            StringSearch();
            break;
          }
          
        }
        
        
        
        

        void ValueSearch()
        {
              int[] array=new int[6]{1,3,5,6,8,9};
        System.Console.WriteLine("Enter the value to search");
        int value=int.Parse(Console.ReadLine());
        int start=0;
        int end=array.Length-1;
        int flag=0;
        while(start<end)
        {
           int mid=(start+end)/2;
           if(array[mid]==value)
           {
             System.Console.WriteLine($"The value is {array[mid]}  and the position of the value is {mid}");
             break;
           }
           
           else  if(array[mid]>value)
           {
             end=mid-1;
             flag=1;
           }
           else if(array[mid]<value)
           {
             start=mid+1;
             flag=1;
           }
           
           
          }
          if(flag==1)
          {
            System.Console.WriteLine("The value is not in the array");
          }
        }


        void CharSearch()
        {
        char[] array=new char[6]{'a','c','e','i','o','u'};
        System.Console.WriteLine("Enter the character to search");
        char character=char.Parse(Console.ReadLine());
        int start=0;
        int end=array.Length-1;
        int flag=0;
        while(start<end)
        {
           int mid=(start+end)/2;
           if(array[mid]==character)
           {
             System.Console.WriteLine($"The character is {array[mid]}  and the position of the character is {mid}");
             break;
           }
           
           else  if(array[mid]>character)
           {
             end=mid-1;
             flag=1;
           }
           else if(array[mid]<character)
           {
             start=mid+1;
             flag=1;
           }
          
           
           
           }
           if(flag==1)
           {
            System.Console.WriteLine("The character is not in the array");
           }
        }

        void StringSearch()
        {
          string [] array=new string [6]{"ajay","dinesh","jeeva","kalai","lakshman","venkat"};
        System.Console.WriteLine("Enter the string to search");
        string str=(Console.ReadLine());
        int start=0;
        int end=array.Length-1;
        int flag=0;
        while(start<end)
        {
           int mid=(start+end)/2;
           if(array[mid]==str)
           {
             System.Console.WriteLine($"The string is {array[mid]}  and the position of the string is {mid}");
             break;
           }
           
           else  if(array[mid].CompareTo(str)>0)
           {
             end=mid-1;
             flag=1;
           }
           else if(array[mid].CompareTo(str)<0)
           {
             start=mid+1;
             flag=1;
           }
          
           
           
           
        }
        if(flag==1)
        {
          System.Console.WriteLine("The string is not in the array");
        }
        }
      }
    }
  