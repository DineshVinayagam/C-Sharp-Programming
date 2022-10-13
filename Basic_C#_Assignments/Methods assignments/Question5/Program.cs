using System;
 namespace Question5;
  class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number:");
        int number=int.Parse(Console.ReadLine());
         Prime(number);
         


         void Prime(int value)
        {
            int flag=0;
            if((value==0)||(value==1))
            {
                flag=0;
            }
            else
            {
                for(int i=2;i<=value/2;i++)
                {
                    if(value%i==0)
                    {
                        flag=0;
                    }
                    else
                    {
                        flag=1;
                    }
                }
                if(flag==1)
                {
                      System.Console.WriteLine("The number is a prime number");
                }
                else
                {
                    System.Console.WriteLine("The number is not a prime number");
                }
            }
            
            
        }
        
       
           
         
          
        }
        
    }
  