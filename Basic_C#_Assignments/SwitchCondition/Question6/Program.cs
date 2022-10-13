using System;
 namespace Question6;
  class program{
    public static void Main(string[] args)
    {
        
        System.Console.WriteLine("Enter the radius of the circle:");
        double radius=double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number to perform the task: 1.Area,2.Perimeter,3.Diameter");
        int number=int.Parse(Console.ReadLine());
        switch(number)
        {
            case 1:
            {
                double area=(double) 22/7*(radius*radius);
                System.Console.WriteLine("The Area of the Circle:"+area);
                break;
            }
            case 2:
            {
                double perimeter=(double)22/7*(2*radius);
                System.Console.WriteLine("The Perimeter of the Circle:"+perimeter);
                break;
            }
            case 3:
            {
                double diameter=(double)2*radius;
                System.Console.WriteLine("The Diameter of the Circle:"+diameter);
                break;
            }
        }
        
        
    }
  }