using System;
 namespace FunctionDeligate;
  class Program{
    static double Sum (int a,int b ) {return a+b;}
    static double Subtract(int a,int b){return a-b;}
    

    static Double Calculator(Func<int,int, double>Operation ,int x,int y)
    {
        return Operation(x,y);
    }

    public static void Main(string[] args)
    {
       System.Console.WriteLine(Calculator(Sum,10,20));
       System.Console.WriteLine(Calculator(Subtract,10,20));
    }
  }