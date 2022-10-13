using System;
 namespace Question11;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string:");
        string word=Console.ReadLine();
        int length=word.Length;
        string remove=" ";
        for(int i=0;i<length;i++)
        {
            if(!remove.Contains(word[i]))
            {
                remove=remove+word[i];
            }
        }
        System.Console.WriteLine($"The entered string after removal of repeted character is:{remove}");
    }
  }