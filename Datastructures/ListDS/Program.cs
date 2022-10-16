using System;
 namespace ListDS;
  class Program{
    public static void Main(string[] args)
    {
        List<int> datas=new List<int>();
        datas.AddElement(10);
        datas.AddElement(3);
        datas.AddElement(5);
        datas.AddElement(7);
        datas.Insert(2,6);
        datas.RemoveAt(3);
        datas.Remove(3);

        foreach(int value in datas)
        {
             System.Console.WriteLine(value);
        }

        for(int i=0;i<datas.Count;i++)
        {
          System.Console.WriteLine(datas[i]);
        }
    }
  }