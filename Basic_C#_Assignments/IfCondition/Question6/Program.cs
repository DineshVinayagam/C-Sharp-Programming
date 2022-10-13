using System;
 namespace Program;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the temperature:");
        float t=float.Parse(Console.ReadLine());
        if (t<0){
            System.Console.WriteLine("Freezing weather");
        }
        else if ((0<=t)&&(t<10))
        {
            System.Console.WriteLine("Very Cold weather");
        }
        else if ((10<=t)&&(t<20)){
            System.Console.WriteLine("Cold Weather");
        }
        else if ((20<=t)&&(t<30)){
            System.Console.WriteLine("Normal in  Temp");
        }
        else if ((30<=t)&&(t<40)){
            System.Console.WriteLine("Its Hot");
        }
        else {
            System.Console.WriteLine("Its Very Hot");
        }
    }
  }