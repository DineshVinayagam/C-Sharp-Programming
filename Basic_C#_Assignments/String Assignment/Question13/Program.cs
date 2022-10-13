using System;
 namespace Question13;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Input String:");
        string word=Console.ReadLine();
        int sum=0;
        for(int i=0;i<word.Length;i++)
        {
            if((word[i]>='0')&& (word[i]<='9'))
            {
                sum=sum+(word[i]-'0');
            }
        }
        System.Console.WriteLine($"The sum of the digits in the string:{sum}");
    }
  }