using System;
 namespace DictionaryDS;
  class Program{
    public static void Main(string[] args)
    {
       Dictionary<int,string> datas=new Dictionary<int, string>();
       datas.AddElement(1,"dinesh");
       datas.AddElement(2,"jeeva");
       datas.AddElement(3,"venkat");
       //datas.Display();
       datas.Remove(2);
       datas.Display();

    }
  }