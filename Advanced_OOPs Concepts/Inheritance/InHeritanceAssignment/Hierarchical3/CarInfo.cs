using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical3
{
    public class CarInfo
    {

         public string RcBookNumber { get;  set;}
         public string  EngineNumber{ get; set; }
         public string ChasisNumber { get; set; }
         public long Milage { get; set; }
         public int TankCapacity{get; set;}
         public int  NumberOfSeats{ get; set; }
         public long NumberOfKmDriven { get; set; }
         public DateTime DateOfPurchase { get; set; }



         public CarInfo(string rcbooknumber, string enginenumber, string chasisnumber,long milage,int tankcapacity,int numberofseats,long numberofkmdriven,DateTime dateofpurchase)
         {
            RcBookNumber=rcbooknumber;
            EngineNumber=enginenumber;
            ChasisNumber=chasisnumber;
            Milage=milage;
            TankCapacity=tankcapacity;
            NumberOfSeats=numberofseats;
            NumberOfKmDriven=numberofkmdriven;
            DateOfPurchase=dateofpurchase;

         }


         public void CalculateMilage()
         {
            System.Console.WriteLine("Enter the Tank filled quantity:");
            int tankfilled=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Km driven");
            int driven=int.Parse(Console.ReadLine());
            int milage1=(tankfilled/driven);
         }
         public void ShowCarInfo()
         {
            System.Console.WriteLine($"The Rc Book Number is: \t{RcBookNumber} ");
            System.Console.WriteLine($"Engine Number is :     \t{EngineNumber}");
            System.Console.WriteLine($"Chasis Number is :     \t{ChasisNumber}");
            System.Console.WriteLine($"Milage is :            \t{Milage}");
            System.Console.WriteLine($"Tank Capacity:         \t{TankCapacity}");
            System.Console.WriteLine($"Number of Seats:       \t{NumberOfSeats}");
            System.Console.WriteLine($"Number Of Km Driven:   \t{NumberOfKmDriven}");
            System.Console.WriteLine($"DateOf Purchase:       \t{DateOfPurchase}");
         }
    }
}