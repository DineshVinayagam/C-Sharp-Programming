using System;
 namespace Question8;
  class Program{
  
     public static void Main(string[] args)
     {
        System.Console.WriteLine("Enter the string:");
        string word=Console.ReadLine().ToLower();
        int length=word.Length;
        System.Console.WriteLine("Enter the position");
        int position=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the length of substring:");
        int sublength=int.Parse(Console.ReadLine());
        char[] array=word.ToCharArray(0,length);
        int count=0;
        System.Console.WriteLine("The extracted substring is:");  
        while(count<sublength)
        {
            char extract=array[position+count-1];
            count++;
            System.Console.Write(extract);
        }
        

     }
  }