using System;
 namespace AbstractClasses;
  class Program{
    public static void Main(string[] args)
    {
        AbstractBase company=new TCS();
        company.Name="Developer";
        company.Display();
        company.Salary(30);
        AbstractBase companysync=new Syncfusion();
        companysync.Name="Test Engineer";
        companysync.Display();
        companysync.Salary(15);
    }
  }