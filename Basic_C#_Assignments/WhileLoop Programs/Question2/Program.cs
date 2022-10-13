using System;
 namespace Question
 {
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the count:");
            double count=double.Parse(Console.ReadLine());
            double number=1;
            double sum=0;
            System.Console.WriteLine("The numbers are:");
            while(number<=count)
            {   
                System.Console.WriteLine(number);
                double square=(double) number*number;
                sum=sum+square;
                

                number++;
            }
            
            System.Console.WriteLine($"The sum of the square:{sum}");
            
        }
    }
 }