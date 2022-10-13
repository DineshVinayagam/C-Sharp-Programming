using System;
 namespace Question1;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the First Number:");
        int number1=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the Second Number");
        int number2=int.Parse(Console.ReadLine());
        int sum= Addition(number1,number2);
        
        System.Console.WriteLine($"The addition of the two numbers:{sum}");

        float sub=Substraction(number1,number2);
        System.Console.WriteLine($"The subtraction of the two numbers:{sub}");

        float mul=Multiplication(number1,number2);
        System.Console.WriteLine($"The multiplication of the two numbers:{mul}");
        float div=Division(number1,number2);
        System.Console.WriteLine($"The division of the two numbers:{div}");

        int Addition( int value1,int value2)
        {
            int sum=value1+value2;
            return sum;
        }
        int Substraction(int value1,int value2)
        {
            int sub=value1-value2;
            return sub;
        }
        int Multiplication(int value1, int value2)
        {
            int mul=value1*value2;
            return mul;
        }
        int Division(int value1,int value2)
        {
           int div=value1/value2;
           return div;
        }
        
    }
  }