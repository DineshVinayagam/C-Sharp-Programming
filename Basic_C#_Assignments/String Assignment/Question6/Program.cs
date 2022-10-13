using System;
 namespace Question6;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string:");
        string word=Console.ReadLine().ToLower();
        int count=0;
        int count1=0;
        int count2=0;
        for(int i=0;i<word.Length;i++)
        {
          if(word[i]>='a' && word[i]<='z')
          {
            count++;
          }
          else if(word[i]>=0 && word[i]<='9')
          {
            count1++;
          }
          else{
            count2++;
          }
        }
        System.Console.WriteLine($"The count of the alphabets is:{count}");
        System.Console.WriteLine($"The count of the Number is:{count1}");
        System.Console.WriteLine($"The count of the Special character is :{count2}");
        
    }
  }