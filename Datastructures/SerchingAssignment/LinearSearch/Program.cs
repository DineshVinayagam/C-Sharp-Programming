using System;
 namespace LinearSearch;
  class Program
  {
     public static void Main(string[] args)
     {
        System.Console.WriteLine("Enter the option 1.Int Linear search 2.char Linear search 3.string linear search");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
           case 1:
           {
            IntSearch();
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
        
        





         void IntSearch()
        {
           int[] array=new int[6] {1,2,4,3,6,4};
        System.Console.WriteLine("Enter the value to search:");
        int value=int.Parse(Console.ReadLine());
        int flag=0;
        for(int i=0;i<array.Length;i++)
        {
            if(value==array[i])
            {
                System.Console.WriteLine($"The value {array[i]} is found and the index value of that number is:{i}");
                break;
            }
            else
            {
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
        char[] array=new char[6] {'a','e','i','o','u','z'};
        System.Console.WriteLine("Enter the character to search:");
        char character=char.Parse(Console.ReadLine());
        int flag=0;
        for(int i=0;i<array.Length;i++)
        {
            if(character==array[i])
            {
                System.Console.WriteLine($"The character {array[i]} is found and the index value of that character is:{i}");
                break;

            }
            else
            {
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
        string[] array=new string[6] {"dinesh","babu","jeeva","arun","venkat","jai"};
        System.Console.WriteLine("Enter the string to search:");
        string string1=(Console.ReadLine());
        int flag=0;
        for(int i=0;i<array.Length;i++)
        {
            if(string1==array[i])
            {
                System.Console.WriteLine($"The string {array[i]} is found and the index value of that string is:{i}");
                break;
            }
            else
            {
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
  