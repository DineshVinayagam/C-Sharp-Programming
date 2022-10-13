using System;
 namespace Question7;
 class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the customer Id:");
        float id=float.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the name:");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter the unit consumed:");
        float unit=float.Parse(Console.ReadLine());
        System.Console.WriteLine($"Customer Name:{name}");
        System.Console.WriteLine($"Customert IDNO:{id}");
        System.Console.WriteLine($"Unit Consumed:{unit}");
        if ((0<=unit)&&(unit<200))
        {
          double billvalue=(double)unit*1.20;
          if(billvalue<100)
          {
            billvalue=100;
            System.Console.WriteLine($"Amount Charges @ Rs1.20 per unit:{billvalue}");
          }
          else{
            System.Console.WriteLine($"Amount Charges @ Rs1.20 per unit:{billvalue}");
              }
        }
        else if((unit>=200)&&(unit<400))
        {   
            double billvalue=(double)unit*1.50;
            if(billvalue>=400)
            {
                double surcharge=(double) billvalue*15/100;
                double newbill=(double)billvalue+surcharge;
                System.Console.WriteLine($"Amount Charges @ Rs1.80 per unit:{newbill}");

            }
            else
            {
            System.Console.WriteLine($"Amount Charges @ Rs1.50 per unit:{billvalue}");
            }
        }
        else if((unit>=400)&&(unit<600))
        {
            double billvalue=(double)unit*1.80;
            double surcharge=(double) billvalue*15/100;
            double newbill=(double)billvalue+surcharge;
            System.Console.WriteLine($"Amount Charges @ Rs1.80 per unit:{newbill}");
            
        }
        else
        {
            double billvalue=(double)unit*2.00;
            double surcharge=(double) billvalue*15/100;
            double newbill=(double)billvalue+surcharge;
            System.Console.WriteLine($"Amount Charges @ Rs1.80 per unit:{newbill}");
        }
    }
 }