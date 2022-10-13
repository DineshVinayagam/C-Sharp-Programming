using System;
 namespace Question7;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string to count:");
        string word=Console.ReadLine().ToLower();
        int count=0;
        int count1=0;
        char[] wordarray=word.ToCharArray();
        for(int i=0;i<word.Length;i++)
        {
            if(wordarray[i]=='a' ||wordarray[i]=='e' ||wordarray[i]=='i' ||wordarray[i]=='o' ||wordarray[i]=='u')
            {
                count++;
            }
            else{
                count1++;
            }
        }
        System.Console.WriteLine($"The Number of vowels in the word is:{count}");
        System.Console.WriteLine($"The Number of consonant in the word is:{count1}");
        
    }
  }