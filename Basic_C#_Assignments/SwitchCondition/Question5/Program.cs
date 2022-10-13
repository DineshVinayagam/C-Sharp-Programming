using System;
 namespace Question5;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the team name:");
        string name=Console.ReadLine().ToLower();
        switch(name)
        {
            case "india":
            {   
                System.Console.WriteLine("1.Dhoni\n 2.Gambhir\n 3.Ashwin\n 4.Jadeja");
                break;
            }
            case "bangaladesh":
            {
                System.Console.WriteLine("1.Shakip\n 2.Mushtafiqur\n 3.Tamim\n 4.Mahmudullah");
                break;
            }
            case "pakistan":
            {
                System.Console.WriteLine("1.Babar Hazam\n 2.AsifAli\n 3.Sarfaraz\n 4.Imran Khan");
                break;
            }
        }
    }
  }