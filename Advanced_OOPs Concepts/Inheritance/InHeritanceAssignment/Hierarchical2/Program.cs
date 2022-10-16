using System;
 namespace Hierarchical2;
class Program{
    public static void Main(string[] args)
    {
        Permanent staff1=new Permanent(18000,"january","Permanent");
        staff1.CalculateSalary();
        staff1.ShowPermanent();
        Temporary staff2=new Temporary(15000,"january","Temporary");
        staff2.CalculateSalary();
        staff2.ShowTemporary();

    }
}
