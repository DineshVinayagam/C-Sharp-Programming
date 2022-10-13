using System;
 namespace Question1;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string:");
        string mainstring=Console.ReadLine();
        char [] chararray=mainstring.ToCharArray();
        System.Console.WriteLine("The characters of the string are:");
        for(int i=0;i<chararray.Length;i++)
        {
          System.Console.WriteLine(chararray[i]);
        }
      
    }
  }
