using System;
 namespace Question3;
  class Program
  {
    public static void Main(string[] args)
    {
      int n1=0;
      int n2=1;
      int n3;
      int i=3;
      System.Console.WriteLine("Enter the number:");
      int number=int.Parse(Console.ReadLine());
      
      System.Console.WriteLine("the fibanocci Series is:");
      System.Console.WriteLine(n1);
      System.Console.WriteLine(n2);
      do{
        n3=n1+n2;
        n1=n2;
        n2=n3;
        System.Console.WriteLine(n3);
        i++;

      }while(i<=number);
      
    }
  }