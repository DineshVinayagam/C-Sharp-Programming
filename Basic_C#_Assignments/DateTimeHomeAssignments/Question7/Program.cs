using System;
 namespace Question7;
  class Program{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2022,10,02,0,0,0);
        DateTime newdate=new DateTime(2022,10,02,12,0,0);
        int comparison=DateTime.Compare(date,newdate);
        string result;
        if(comparison<0)
        {
            result="Is earlier than";

        }
        else if(comparison==0)
        {
            result="Is Same As the Time";
        }
        else{
           result="Is Later Than";
        }
        System.Console.WriteLine($"{date} {date:t} {result} {newdate} {newdate:t}");
        
        
    }
  }