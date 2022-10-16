using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical3
{
    public class Tata:CarInfo
    {
        public string CarModelName { get; set; }
        public string CarModelNumber{get; set;}



        public Tata(string rcbooknumber, string enginenumber, string chasisnumber,long milage,int tankcapacity,int numberofseats,long numberofkmdriven,DateTime dateofpurchase,string carmodelname,string carmodelnumber):base (rcbooknumber, enginenumber, chasisnumber,milage,tankcapacity,numberofseats,numberofkmdriven,dateofpurchase)
        {
            CarModelName=carmodelname;
            CarModelNumber=carmodelnumber;
        }

         public  void ShowInfo()
         {
            System.Console.WriteLine($"TheModelName:{CarModelName}\n The Car Model Number:{CarModelNumber}");
            ShowCarInfo();
         }
        
    }

}