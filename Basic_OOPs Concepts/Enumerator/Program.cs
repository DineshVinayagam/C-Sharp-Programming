using System;
 namespace Enumerator;
 public enum Gender{Default, Male, Female, TransGender}
  class Program
  {
    public static void Main(string[] args)
    {   
        //select string or integer
        System.Console.WriteLine("Select Gender Options Male, Female, Transgender:");
        Gender gender1=Enum.Parse<Gender>(Console.ReadLine(),true);
        Console.WriteLine(gender1);

        //Select by string or integer
        System.Console.WriteLine("secect Gender Options Male,Female, Transgender:");
        Gender gender2=Gender.Default;
        bool temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
        while(!temp || !((int)gender2<4 && (int) gender2>0))
        {
          System.Console.WriteLine("Invalid Gender \n Enter again ");
          temp=Enum.TryParse<Gender>(Console.ReadLine(),out gender2);
        }
        System.Console.WriteLine(gender2);
        


        
    }
  }
