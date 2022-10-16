using System;
 namespace SingleCastingDeligate;
 public delegate int Calculator(int n);
 class Program
 {
    static int value=10;
    public static int AddNum(int number){value+=number; return value;}
    public static int MultNum(int number){value*=number; return value;}
    public static int GetNum(){return value;}


    static void Main(string[] args)
    {
        Calculator nc1=new Calculator(AddNum);
        Calculator nc2=new Calculator(MultNum);
        nc1(25);
        System.Console.WriteLine("Value of Num:{0}",GetNum());
        nc2(5);
        System.Console.WriteLine("Value of Num:{0}",GetNum());
        Console.ReadKey();
    
        
    }
 }
