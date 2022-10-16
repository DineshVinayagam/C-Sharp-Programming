using System;
 namespace Hierarchical3;
  class Program{
    public static void Main(string[] args)
    {
        Tata car1=new Tata("23456","345","678",98,30,10,300,new DateTime(2021,09,04),"Tata nano","tata123");
        car1.CalculateMilage();
        car1.ShowInfo();
        Suzuki car2=new Suzuki("98jjdf","kd4984","kj098",40,30,20,400,new DateTime(2006,10,04),"maruthi","839374jh");
        car2.CalculateMilage();
        car2.ShowInfo();
    }
  }