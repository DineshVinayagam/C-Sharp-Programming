using System;
 namespace OperatorOverLoading;
  class Program{
    public static void Main(string[] args)
    {   
        
        Box box1=new Box(3.4,5.6,5.7);
        Box box2=new Box(10,11.2,13.4);
        box1.CalculateVolume();
        box2.CalculateVolume();
        Box box3=box1+box2;
        box3.CalculateVolume();
       
        
    }
  }