using System;
 namespace Question2;
  class Program{
    public static void Main(string[] args)
    {
        int number;
       
        int num=0;
        int i=0;
        do{
            System.Console.WriteLine("enter the number:");
            number=int.Parse(Console.ReadLine());
            if(number>0){
            num=num+number;}
            i++;
        }while(number>0);
        System.Console.WriteLine("the sum is :"+num);
        
    }
  }