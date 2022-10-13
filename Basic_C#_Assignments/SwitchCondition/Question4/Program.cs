using System;
 namespace Question4;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: 1.Addition, 2.Subtraction, 3.Multiplication,4.Division");
        int number=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the first number:");
        int number1=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the second number:");
        int number2=int.Parse(Console.ReadLine());
        
        switch(number)
        {
          case 1:
          {
          int sum=number1+number2;
          System.Console.WriteLine("The Addition of the two number is :"+sum);
          break;}
          case 2:
          {
            int sub=number1-number2;
            System.Console.WriteLine("The Subtraction of the two number is :"+sub);
            break;
          }
          case 3:
          {
            int mul=number1*number2;
            System.Console.WriteLine("The Multiplication of the two number is:"+mul);
            break;
          }
          case 4:
          {
            int div=number1/number2;
            System.Console.WriteLine("The Division of the two number is;"+div);
            break;
          }

          
        }
        
    }
  }