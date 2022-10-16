using System;
 namespace ArrayListDS;
  class Program{
   public static void Main(string[] args)
   {
    ArrayList<Object> datas=new ArrayList<Object>();
        datas.AddElement(10);
        datas.AddElement(3);
        datas.AddElement(5);
        datas.AddElement(7);
        datas.Insert(2,6);
        datas.RemoveAt(3);
        datas.Remove(3);
   }
  }