using System;
 namespace ExceptionHandling;
  class Program{
    public static void Main(string[] args)
    {
        try{
        System.Console.WriteLine("Enter the input 1");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the input 2");
        int number2=int.Parse(Console.ReadLine());
        int output=number1/number2;
        }
        catch(DivideByZeroException e)
        {
            System.Console.WriteLine("An Exception occurred:{0}",e.Message);
            System.Console.WriteLine(e.StackTrace);
        }
        
        catch(FormatException e)
        {
           
            System.Console.WriteLine("An Exception occurred:{0}",e.StackTrace);
            System.Console.WriteLine(e.Message);
        }
        catch(System.Exception e)
        {
             System.Console.WriteLine("General exception occurred:{0}",e.StackTrace);
             System.Console.WriteLine(e.Message);
        }
        finally
        {
            System.Console.WriteLine("All Exceptions Handled Properly");
        }
        
    }
  }
