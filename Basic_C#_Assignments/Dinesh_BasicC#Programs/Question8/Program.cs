using System;
 namespace Question8
 {
    class Program
    {
        public static void Main(string[] args)
        {
        System.Console.WriteLine("Enter the value in meters:");
        float meter=float.Parse(Console.ReadLine());
        float cm= meter*100;
        System.Console.WriteLine($"Cm value:{cm}");
        float mm= cm*10;
        double inch=meter*39.3;
        float foot=12*meter;
        double mile=0.0006213715277778*meter;
        System.Console.WriteLine($"Mm value:{mm}");
        System.Console.WriteLine($"Inch value:{inch}");
        System.Console.WriteLine($"Foot value:{foot}");
        System.Console.WriteLine($"Mile value:{mile}");


        }
    }
 }