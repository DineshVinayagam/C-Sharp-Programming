using System;
 namespace Question9;
 class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number");
        int number=int.Parse(Console.ReadLine());
        int digit;
        int sum=0;
        int value=number;
        for(;;)
        {
            if(number>0)
            {
                digit=number%10;
                sum=sum+(digit*digit*digit);
                number=number/10;
            }
            else
            {
               break;
            }
        }
        if(value==sum)
        {
            System.Console.WriteLine("The entered value is Armstrong number");
        }
        
    }
 }