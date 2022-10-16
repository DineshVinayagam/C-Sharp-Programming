using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp
{
    public class FoodDetails
    {
        private static int s_foodid=100;
        public string FoodID { get;  }
        public string FoodName { get; set; }
        public int  FoodCount{ get; set; }
        public int FoodPrice{ get; set; }


        public FoodDetails(string foodName,int foodCount,int foodPrice)
        {
            s_foodid++;
            FoodID="FID"+s_foodid;
            FoodName=foodName;
            FoodCount=foodCount;
            FoodPrice=foodPrice;
        }

        public FoodDetails(string data)
        {
            string[] values=data.Split(',');
            s_foodid=int.Parse(values[0].Remove(0,3));
            FoodID=values[0];
            FoodName=values[1];
            FoodCount=int.Parse(values[2]);
            FoodPrice=int.Parse(values[3]);
        }
    }
}