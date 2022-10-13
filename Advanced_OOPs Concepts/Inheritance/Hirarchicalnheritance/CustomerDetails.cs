using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HirarchicalInheritance
{
    public class CustomerDetails:PersonalDetails
    {

        private static int s_customerId=1000;
        public string CustomerId { get; }
        public double  Balance { get; set; }



        public CustomerDetails(string aadharnumber,string name,string fathersname, Gender gender, long phone,double balance):base ( aadharnumber, name,fathersname,gender,phone)
        {
           s_customerId++;
           CustomerId="CF"+s_customerId;
           Balance=Balance;


        }
        public void ShowCustomer()
        {
            System.Console.WriteLine($"{CustomerId} {Balance} ");
            ShowDetails();
        }
    }
}
