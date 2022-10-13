using System;
 namespace Question10;
  class Program{
    public static void Main(string[] args)
    {
        string day=DateTime.Today.ToString("dd/MM/yyyy");
        DateTime yesterday=Yesterday();
        DateTime tommorrow=Tommorrow();
        System.Console.WriteLine($"Yesterday{yesterday.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Tommorrow {tommorrow.ToString("dd/MM/yyyy")}");
        




        DateTime Yesterday()
        {
           return DateTime.Today.AddDays(-1);
        }

        DateTime Tommorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
  }