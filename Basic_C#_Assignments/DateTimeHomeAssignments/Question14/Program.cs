using System;
 namespace Question14;
  class Program
  {
    public static void Main(string[] args)
    {
        int salary;
        int amount =500;
        System.Console.WriteLine("Enter the Month In Number: Like 1,2,3.....");
        int month=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Number of Leave Taken From the Month:");
        int leave=int.Parse(Console.ReadLine());
        switch(month)
        {
            case 2:
            {
                
                salary=(28-leave)*amount;
                System.Console.WriteLine($"Your  Salary For This Month Is : {salary}");
                break;
            }
            case 1: case 3: case 5: case 7: case 8: case 10: case 12:
            {
                salary=(31-leave)*amount;
                System.Console.WriteLine($"Your Salary For this Month Is: {salary}");
                break;
            }
            case 4: case 6: case 9: case 11:
            {
                salary=(30-leave)*amount;
                System.Console.WriteLine($"Your salary For This Month Is: {salary}");
                break;
            }
        }
        

    }
  }