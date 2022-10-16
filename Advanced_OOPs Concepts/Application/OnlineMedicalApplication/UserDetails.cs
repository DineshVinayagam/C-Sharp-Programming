using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalApplication
{
    public class UserDetails
    {
        private static int s_userId=1000;
        public string UserID { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public long Mobile { get; set; }
        public double Balance { get; set; }




        public UserDetails(string name,int age,string city,long mobile,double balance)
        {
            s_userId++;
            UserID="UID"+s_userId;
            Name=name;
            Age=age;
            City=city;
            Mobile=mobile;
            Balance=balance;

        }
        public UserDetails(string data)
        {
            string[] values=data.Split(',');
            s_userId=int.Parse(values[0].Remove(0,3));
            UserID=values[0];
            Name=values[1];
            Age=int.Parse(values[2]);
            City=values[3];
            Mobile=long.Parse(values[4]);
            Balance=double.Parse(values[5]);
        }
    }
}